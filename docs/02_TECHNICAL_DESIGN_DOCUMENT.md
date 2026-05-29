# Clatterhaul — Technical Design Document (TDD)

**Version:** 2.0 (post-review)  ·  **Owner:** Lead Architects + Networking Engineers  ·  Unity 6000.4.4f1 / URP  ·  Mirror + Steam P2P

> v2.0 adds the networking/architecture for the new systems: emotes & proximity voice, host-recorded replay + Disaster Cam, Photo Mode, Blueprint Garage sync, deterministic mutator seeds, FeelProfile data, modes/contracts state, save schema v2, telemetry, and updated performance budgets.

## 1. Architecture & assemblies
```
Core/        gameplay logic, no Mirror (state machines, run/contract/boss-haul, economy calc, mutator seeds, FeelProfile)
Net/         Mirror NetworkManager, Steam lobby/transport, voice, emote sync, replay capture, blueprint sync
Player/      input routing, active-ragdoll, physics-hands grab
Contraption/ modules, stations, joints, payload, assembly runtime
Environment/ hazards, Calamity events, biome streaming
Meta/        currencies, ranks, unlocks, challenges, save service, telemetry
UI/          HUD, garage/blueprint editor, replay theater, photo mode, leaderboards (MVVM-lite)
Audio/       FMOD strain/feedback driver
```
Dependencies point inward; `Core` stays Mirror-free (SOLID, testable).

## 2. Networking model (host-authoritative)
- Host simulates ALL physics (contraption, payload, ragdolls, hazards, Calamity); clients send input `[Command]`, receive `NetworkTransform`/`NetworkRigidbody` + `[SyncVar]`/`SyncList` state.
- 2–4 players, friends-first; FizzySteamworks relay; lobby via Steamworks.NET.
- Physics tick on FixedUpdate (50Hz; eval 60Hz); snapshot interpolation for remote bodies.
- **No host migration at launch** (documented); host-leave → graceful run-end + payout of banked progress.

## 3. New-system networking
| System | Approach |
|---|---|
| **Emotes** | client `[Command]` → server `[ClientRpc]` plays networked emote/anim; cosmetic only |
| **Proximity voice** | Dissonance/Steam voice, positional, host-relayed; mute/volume client-local |
| **Replay / Disaster Cam** | **host records** lightweight transform keyframes (ring buffer ~30s) + event markers; clients request clip export of host buffer; Disaster-Cam is a client-local camera state triggered by a replicated event flag |
| **Photo Mode** | client-local pause-cam (host keeps simulating or a "safe" sandbox pause in solo); no net authority needed |
| **Blueprint Garage** | blueprint = serialized module graph (ids + transforms + joints); host instantiates & validates on depart; sharing via Steam Workshop / file string |
| **Mutators / Daily** | deterministic **seed** (UTC date for Daily) drives mutator selection on all clients identically (Core, Mirror-free); host authoritative on application |
| **Leaderboards** | Steam Leaderboards; Daily uses seed + server-side sanity checks (time/score bounds) to deter trivial cheating; cosmetics-only rewards reduce cheat incentive |

## 4. Contraption assembly runtime
- Modules are prefabs with `ContraptionModule` + joint configs + a `FeelProfile`. The assembly system builds the rigidbody graph from a blueprint at depart, arms break thresholds, computes center-of-mass/ballast, and validates connectivity. Cosmetic modules carry zero physics cost.

## 5. Data: FeelProfile & tunables
- `FeelProfile` (SO): hit-stop ms, shake amp/dur, squash curve, VFX/SFX/FMOD refs, haptic profile, slow-mo trigger threshold. Designers tune feel without code (doc 10).
- All gameplay constants in SOs (module vectors, mutator effects, payout curves).

## 6. Save schema v2 (local; Easy Save 3)
```
Profile { scrip, sprockets, unionRank, rankXp, prestige,
          unlockedModules[], unlockedBiomes[], unlockedMutators[],
          ownedCosmetics[], equipped{}, blueprints[], 
          challenges{daily[],weekly[],progress}, settings{accessibility,audio,controls},
          stats{perfectHauls[], bestTimes{}, clipsShared} }
```
Daily-seed derived from UTC date so friends share the same daily without sync. Cloud save via Steam Cloud.

## 7. Performance budget (updated)
| Target | Spec |
|---|---|
| 1080p 60 FPS | mid PC (GTX 1660 / RX 580) |
| Steam Deck | 40–60 FPS native, verified |
| Frame | ≤ 16.6 ms; physics ≤ 4 ms; render ≤ 8 ms |
| Active rigidbodies | ~60 (contraption+debris); debris pooled; mutators cap body counts |
| Replay buffer | transform-keyframe ring (~30s), LOD-decimated; off-thread serialize on export |
| VFX | pooled; particle budget per biome; Disaster-Cam slow-mo must not spike GC |
Profiling each milestone (doc 06). SRP Batcher + GPU instancing on modular kits; baked GI + light probes.

## 8. Telemetry (opt-in, feeds economy/live-ops)
Scrip/hour, time-to-next-unlock, module pick-rate per biome, challenge completion, clip exports, laugh-proxy (Disaster-Cam triggers/session), crash/ANR, perf percentiles. Privacy-respecting, toggleable.

## 9. Build & CI
Windows x64 IL2CPP. GitHub Actions: restore → EditMode tests → (optional) PlayMode smoke → lint. Branch/phase → review → merge to main.

## 10. Risk register (technical)
| Risk | Mitigation |
|---|---|
| Replay/VFX perf on Deck | LOD ring buffer, pooling, off-thread export, body caps |
| Physics desync | host-authoritative only; never trust client physics |
| Blueprint exploit/instability | server validation, connectivity & mass checks, fallback rig |
| Daily leaderboard cheating | seed + bounds checks; cosmetic-only rewards |
| Voice CPU/bandwidth | codec tuning, distance culling, opus low-bitrate |

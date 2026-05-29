# Clatterhaul — Technical Design Document (TDD)

**Version:** 1.0 (Phase 2)  ·  **Owner:** Lead Unity Architect + Networking Engineers  ·  **Engine:** Unity 6000.4.4f1 / URP

---

## 1. High-level architecture

Clean, SOLID, assembly-separated. Gameplay never references networking transport directly — it talks to interfaces.

```
Assets/_Project/Scripts/
  Core/         → game state, run flow, modifiers, interfaces (no Unity-scene deps where possible)
  Networking/   → Mirror NetworkManager, Steam lobby/transport, voice
  Player/       → input routing, physics-hands grab, ragdoll
  Contraption/  → modules, stations, joints, payload
  Environment/  → hazards, events, biome streaming
  UI/           → HUD, lobby, ping wheel (MVVM-lite)
  Audio/        → strain/feedback audio driver
```

Assembly definitions: `Clatterhaul.Runtime` (gameplay), `Clatterhaul.Net` (networking, refs Mirror), `Clatterhaul.Tests.EditMode`, `Clatterhaul.Tests.PlayMode`. Dependencies point inward (Core has no dependency on Net/UI).

## 2. Networking model

- **Stack:** **Mirror** + **FizzySteamworks** transport + **Steamworks.NET** (lobbies, friend invites, P2P relay).
- **Topology:** **Host-authoritative** (listen server). One player hosts; the host simulates *all physics* (contraption joints, payload, ragdolls). Clients send input via `[Command]`; host replicates state via `NetworkTransform`/`NetworkRigidbodyReliable` + `[SyncVar]`/`SyncList`.
- **Why host-authoritative:** joint-heavy rigidbody physics cannot be made deterministic across machines; a single authority eliminates desync. Cost-free for friend sessions (no dedicated servers).
- **What is networked:**
  - *Server-simulated, client-interpolated:* contraption rigidbodies, payload, ragdolls.
  - *Command → server:* station inputs (steer/pedal/crank), grab/release intents, ready-up.
  - *SyncVar:* run state, payload condition, modifier set, score.
- **Tick:** physics on `FixedUpdate` (default 50Hz; evaluate 60Hz). Snapshot interpolation via Mirror's built-in buffer for smooth remote bodies.
- **Lobby flow:** Steam invite → `SteamLobbyService` creates/join lobby → Mirror starts host/client on lobby owner → hub scene → ready → load biome (additive).
- **Late join:** allowed in hub; in-run joiners spectate to next safe checkpoint, then spawn.
- **Voice:** distance-attenuated VOIP (Steamworks voice or Dissonance asset — see asset doc). First-class feature.
- **No host migration at launch** (documented limitation; host leaving ends the run — acceptable for friend sessions; revisit post-launch).

## 3. Physics & the contraption

- **Bodies:** prefer `ArticulationBody` for the locomotion chain (stable joint solving) where suitable; `Rigidbody` + `ConfigurableJoint` for breakable cosmetic/cargo links.
- **Breakage:** joints expose break force/torque; on break, spawn debris + audio + "disaster cam" trigger.
- **Grab (physics-hands):** `PhysicsHandGrab` creates a `ConfigurableJoint`/`FixedJoint` between hand and target on grab; springs tuned for Human-Fall-Flat feel. Grab intent is a Command; the *joint* is created on the host only.
- **Stability tuning:** solver iterations raised on the contraption; center-of-mass authored per chassis; outriggers add anti-tip torque.
- **Determinism note:** we do NOT rely on cross-client determinism; host is the single source of truth.

## 4. Core systems (see code stubs in `Assets/_Project/Scripts`)

- `GameStateMachine` — Boot → MainMenu → Lobby → Hub → Haul → Extraction → Payout (and back). Pure C#, event-driven.
- `HaulRunManager` — owns a run: route, checkpoints, payload condition, score; raises events the UI/Audio observe.
- `RunModifier` (ScriptableObject) + `RunModifierDeck` — data-driven modifier system; deterministic daily seed.
- Interfaces: `IInteractable`, `IGrabbable`, `IStation`, `IPayload`, `IHazard`.

## 5. Data & save

- Local profile (unlocks, cosmetics, settings) via a save service (Easy Save 3 or JSON). No server-side accounts at launch. Daily-modifier seed derived from UTC date (so friends share the same daily).

## 6. Performance budget

| Target | Spec |
|---|---|
| 1080p 60 FPS | mid-range PC (GTX 1660 / RX 580 class) |
| Steam Deck | 40–60 FPS at native, verified |
| Frame budget | ≤ 16.6 ms; physics ≤ 4 ms; render ≤ 8 ms |
| Draw calls | < 1500 via SRP Batcher + GPU instancing on biome modules |
| Rigidbodies (active) | budget ~60 contraption/debris bodies; pool debris |

Profiling cadence: QA runs the Unity Profiler each milestone; physics-heavy scenes flagged. URP forward+ ; bake static lighting; light probes for dynamic props.

## 7. Build & CI

- Windows x64 IL2CPP release. GitHub Actions stub (lint + EditMode tests) documented in Phase 3. Branch-per-phase → PR → QA sign-off → merge.

## 8. Risk register (technical)

| Risk | Mitigation |
|---|---|
| Physics "feel" jank | Lock grab/joint feel in M2; weekly feel playtests; tunable spring params as SO |
| Network desync of bodies | Host-authoritative only; never trust client physics |
| Steam P2P NAT issues | FizzySteamworks relay fallback; test across NAT types |
| Perf on Deck | Aggressive LODs, debris pooling, modifier-capped body counts |

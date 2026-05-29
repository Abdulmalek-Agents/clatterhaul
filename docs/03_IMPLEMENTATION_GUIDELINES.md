# Clatterhaul — Implementation Guidelines (Build Plan)

**Version:** 1.0 (Phase 2)  ·  **Owner:** Lead Unity Architect + Senior Unity Developers

> A milestone-ordered, dependency-aware build plan — *ready to start Unity development*. No time estimates by policy; sequence and Definition-of-Done only.

## Coding standards

- C# 9+, `nullable` enabled where practical. One class per file. PascalCase types/methods, `_camelCase` private fields, `I`-prefixed interfaces.
- SOLID: depend on interfaces, not transports. Core assembly must not reference Mirror.
- Every public type/method has XML doc comments. No magic numbers — use serialized fields / SO config.
- All gameplay tunables live in ScriptableObjects so designers iterate without code.
- Each system ships with an EditMode test stub at minimum.

## Milestone sequence

### M0 — Project & pipeline (foundation)
- URP configured (Deck-safe quality tiers), Input System actions asset, assembly definitions, folder structure, save service.
- **DoD:** empty hub scene boots through `GameStateMachine` to a playable local character.

### M1 — Networking spine
- Import Mirror + FizzySteamworks + Steamworks.NET. `ClatterNetworkManager`, `SteamLobbyService` (create/join/invite), player spawn, name tags.
- **DoD:** 2–4 players join via Steam invite into the hub and see each other move.

### M2 — Player + physics-hands (the feel)
- `PlayerInputRouter`, locomotion, ragdoll, `PhysicsHandGrab` (networked grab via Command, host-side joint).
- **DoD:** players can grab/carry/throw props together; grab feel signed off in a feel playtest.

### M3 — The contraption
- `ContraptionModule` base + chassis/locomotion/lift/stabilizer; `ContraptionStation` (steer/pedal/crank) with networked hand-off; `Payload` with condition.
- **DoD:** a 2–4p crew drives a basic rig with a payload across a flat test track.

### M4 — Hazards, run flow & modifiers
- `HaulRunManager` (route/checkpoints/score), `IHazard` set (ravine/mud/ice/wind), `RunModifierDeck` (daily seed), extraction + payout, disaster-cam.
- **DoD:** full prep→haul→extract→payout loop on 1 biome with 3 hazards + 1 modifier.

### M5 — Vertical slice biome (Canyon) + UX/Audio
- Canyon biome dressed to ship quality (see Art/Environment plan), HUD, ping wheel, proximity voice, strain-audio driver, settings/accessibility.
- **DoD:** Canyon is demo-ready and survives the QA + Art/Environment joint review.

### M6 — Content scale-out
- Remaining 5 biomes, branching routes, full modifier deck, cosmetics/unlocks, leaderboards, localization hooks.
- **DoD:** ~10h content target met; review-readiness checklist green.

## Definition of Done (every feature)
1. Code reviewed (SOLID, commented). 2. EditMode/PlayMode test stub present & passing. 3. Networked path verified with 2–4 clients. 4. Profiled within budget. 5. QA + (if it touches scenes) Art/Environment sign-off. 6. STUDIO_LOG updated.

## Test strategy
- **EditMode:** pure logic (run scoring, modifier seeding, state machine transitions).
- **PlayMode:** spawn/grab/station hand-off, hazard triggers, payload condition.
- **Network:** Mirror's multi-instance + ParrelSync for 2–4 local clients; latency simulation via transport settings.

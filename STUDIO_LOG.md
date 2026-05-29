# STUDIO_LOG — Clatterhaul

Living log of phases, decisions, blockers, retries, asset-placement notes, and next steps. Newest entries on top.

---

## Phase 2 — Technical & Assets  ·  status: IN REVIEW → PR open

### Done
- `docs/02_TECHNICAL_DESIGN_DOCUMENT.md` — architecture, host-authoritative Mirror model, physics/contraption, perf budget, technical risk register.
- `docs/03_IMPLEMENTATION_GUIDELINES.md` — M0–M6 milestone build plan, coding standards, DoD, test strategy.
- `docs/04_UNITY_ASSET_INTEGRATION.md` — evaluated asset list (Mirror, FizzySteamworks, Steamworks.NET, Dissonance, PuppetMaster, Obi Rope, DOTween Pro, Synty POLYGON, FMOD, Easy Save 3) with license/perf/conflict notes + integration rules.
- `docs/05_ART_AND_ENVIRONMENT_PLAN.md` — art direction, biome palettes, **environment dressing standards** (grounding/pivots/LODs/lightmap UVs/hierarchy), lighting/baking, optimization.
- `docs/06_QA_TEST_PLAN.md` — QA mandate, test matrix, environment-review checklist, bug template, phase gates.
- **Code stubs** (SOLID, fully commented): Core (Mirror-free) `Interfaces`, `GameStateMachine`, `HaulRunManager`, `RunModifier`, `RunModifierDeck`; Net (Mirror) `ClatterNetworkManager`, `SteamLobbyService`, `PhysicsHandGrab`, `ContraptionModule`, `ContraptionStation`, `Payload`. Assembly defs isolate Core from Mirror.
- **Unit tests:** `HaulRunManagerTests`, `RunModifierDeckTests` (EditMode).

### Decisions
- Core gameplay assembly (`Clatterhaul.Runtime`) is **forbidden from referencing Mirror**; all networked code lives in `Clatterhaul.Net`. Enforces SOLID/testability.
- Daily modifier seed is **UTC-date-derived** so friends share the same daily with zero network sync.
- `SteamLobbyService` deliberately avoids direct Steamworks.NET type references so the project compiles before the SDK is imported.

### Asset-placement notes
- No scenes dressed yet (skeleton). First environment-review pass occurs in Phase 3 (Canyon vertical slice). Synty POLYGON props flagged for a pivot/grounding/lightmap-UV audit on import.

### Retry log
- No retryable tool errors encountered this phase.

### Next steps (Phase 3)
- Build the Canyon vertical slice; full prep→haul→extract loop 2–4p; proximity voice; CI (lint + EditMode tests); joint QA + Art/Environment review; review-readiness checklist.

---

## Phase 1 — Foundation  ·  status: MERGED ✅

### Done
- Repo created in `Abdulmalek-Agents` org; `phase-1-foundation` branch; PR #1 merged after QA sign-off.
- Unity **6000.4.4f1** skeleton (URP 17, Cinemachine 3, Input System, Test Framework), `.gitignore`, `Assets/_Project` structure.
- Design docs: GDD (`01`), Narrative bible (`07`), Portfolio validation (`00`), this log.

### Decisions
- **Networking = Mirror + FizzySteamworks (Steam P2P), host-authoritative.** Photon Fusion 2 = documented fallback.
- **URP** (approved exception to studio HDRP default for perf + stylized art).
- Modules are **sidegrades** (no power creep) to protect cross-skill co-op & review score.

### Retry log
- None.

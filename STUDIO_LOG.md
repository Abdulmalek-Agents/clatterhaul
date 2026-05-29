# STUDIO_LOG — Clatterhaul

Living log of phases, decisions, blockers, retries, asset-placement notes, and next steps. Newest entries on top.

---

## Phase 1 — Foundation  ·  status: IN REVIEW → PR open

**Date:** project kickoff.

### Done
- Repo created in `Abdulmalek-Agents` org.
- Branch `phase-1-foundation` created.
- Unity **6000.4.4f1** project skeleton committed: `ProjectSettings/ProjectVersion.txt`, `Packages/manifest.json` (URP 17, Cinemachine 3, Input System, Test Framework), Unity `.gitignore`, `Assets/_Project` folder structure.
- Design docs committed: GDD (`01`), Narrative & World bible (`07`), Portfolio validation (`00`), this log.

### Decisions
- **Networking = Mirror + FizzySteamworks (Steam P2P), host-authoritative.** Rationale: joint-heavy physics needs a single authority; Mirror is free (no CCU fees) and ideal for friend-hosted sessions. Photon Fusion 2 documented as fallback for managed matchmaking.
- **Render pipeline = URP** (stylized, Steam-Deck-friendly performance budget) — deviates from studio HDRP default intentionally for perf + art style; logged as an approved exception.
- **Module = sidegrade, never strict upgrade** to protect cross-skill group play and review score.

### Blockers resolved
- None.

### Retry log
- No retryable tool errors encountered this phase.

### Next steps (Phase 2)
- Technical Design Doc, Implementation Guidelines, Unity Asset Integration plan, Art & Environment plan, QA Test Plan.
- C# core stubs (SOLID, fully commented) + unit-test stubs.
- Open Phase 1 PR; merge after QA + Art/Environment sign-off.

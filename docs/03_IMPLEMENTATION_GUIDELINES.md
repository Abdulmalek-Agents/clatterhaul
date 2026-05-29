# Clatterhaul — Implementation Guidelines (Build Plan)

**Version:** 2.0 (post-review)  ·  **Owner:** Lead Architect + Senior Unity Developers

> Milestone-ordered, dependency-aware, no time estimates (policy). v2.0 expands the backlog to cover review-driven systems while **protecting vertical-slice scope** (R3-SCOPE-8): every new system reuses the one physics loop + asset-store art.

## Coding standards
C# 9+, one class/file, interfaces over transports, XML docs on public APIs, all tunables in ScriptableObjects, EditMode test per logic system. `Clatterhaul.Runtime` (Core) must not reference Mirror.

## Milestone sequence

### M0 — Project & pipeline
URP (Deck tiers), Input System, assembly defs, save service, FeelProfile SO framework.
**DoD:** local character boots through GameStateMachine into a test hub.

### M1 — Networking spine
Mirror + FizzySteamworks + Steamworks.NET; lobby/invite; player spawn; proximity voice.
**DoD:** 2–4 players join via Steam invite and move + talk in hub.

### M2 — Player & physics-hands (THE FEEL)
Active ragdoll (PuppetMaster), grab (networked Command, host joint), full **FeelProfile** stack (hit-stop/shake/squash/VFX/SFX/haptics), Disaster-Cam.
**DoD:** grab/carry/throw + a catastrophe auto-produces a slow-mo clip; feel signed off (doc 10 checklist).

### M3 — Contraption & Blueprint Garage
Module base + classes, stations (networked hand-off), payload + condition + cargo reactions, snap-grid Blueprint editor, assembly runtime + validation.
**DoD:** crew builds a rig in the Garage and drives it with a reacting payload on a test track.

### M4 — Run flow, hazards, Calamity & modes
HaulRunManager (route/checkpoints/score), IHazard set, one Calamity, extraction/payout, Contracts + Endless + Daily (seeded mutators), Blooper Reel + gravestone.
**DoD:** full Prep→Haul→Calamity→Boss-stub→Extract→Payout→Blooper loop, 2–4p, one biome.

### M5 — Canyon vertical slice (ship-quality)
Canyon dressed/lit to bar (doc 05), Canyon Boss-Haul "Collapsing Mesa," HUD, ping/emote wheels, onboarding "First Hill," economy v1, replay/photo/clip export.
**DoD:** Canyon demo-ready; passes joint QA+Art review + Feel + Laugh audits; Deck perf green.

### M6 — Meta & progression
Currencies, 20 Union Ranks, unlock tables, challenges (daily/weekly), cosmetics, leaderboards, telemetry, Steam Cloud save.
**DoD:** unlock cadence matches doc 09; no power-creep (sidegrade audit).

### M7 — Content scale-out
Remaining 5 biomes (signature systems, Calamities, Boss-Hauls), full module set (~40), 12+ cargo, ~16 mutators, 60+ cosmetics, Workshop blueprint sharing.
**DoD:** ~10h target met (doc 09); biome DoD checklist green for each.

### M8 — Polish, accessibility, launch prep
Accessibility suite (doc 16), localization text, marketing build (doc 18), Next-Fest demo cut, perf hardening, full QA regression.
**DoD:** review-readiness checklist green; demo shipped to Next Fest.

## Review-finding → milestone traceability
| Finding | Milestone |
|---|---|
| Feel/Juice (R1-FEEL-4, R2-FEEL-3) | M2 |
| Blueprint Garage (R1-CONTRA-6) | M3 |
| Modes/Daily/Endless (R1-MModes-8) | M4 |
| Humor engine (R1-FUN-3, R2-HUMOR-2) | M2–M5 |
| 10h pacing/contracts (R1-DEPTH-2) | M5–M7 |
| Economy/meta (R1-PROG-7) | M6 |
| Biome level design (R2-LV-5) | M7 |
| Accessibility (R2-ACC-12) | M8 |
| Live-ops hooks (R2-LIVE-13) | M6–M8 |

## Definition of Done (every feature)
Reviewed + commented; test stub passing; networked path verified 2–4p; profiled; QA (+ Art/Env for scenes) sign-off; STUDIO_LOG updated.

## Test strategy
EditMode (pure logic: payout, mutator seed, rank XP, state machine); PlayMode (grab, station hand-off, hazard, payload, Calamity); Network (ParrelSync 2–4 + latency sim); Fun (Laugh/Feel audits, doc 06).

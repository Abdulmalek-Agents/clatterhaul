# Clatterhaul — Review & Critique Log (50-Person Senior Board · 3 Rounds)

**Version:** 2.0 polish cycle  ·  **Owner:** Creative Director / Review Board Chair  ·  **Outcome:** GREEN-LIT for v2.0 documentation set

> Mandate: stress-test Clatterhaul for **polish, depth, fun, humor, and engagement**, expand the spec to fully capture a **~10-hour experience**, and re-author every design document accordingly. This log records the board, the methodology, and every finding with its resolution. The resolutions are implemented in the v2.0 docs (01–18).

---

## 1. The review board (50 senior staff)

| # | Discipline group | Count | Seats |
|---|---|---|---|
| 1 | Creative Director / Review Board Chair | 1 | Chair |
| 2 | Game Directors | 2 | GD-1, GD-2 |
| 3 | Lead Game Designers | 2 | LD-1, LD-2 |
| 4 | Systems Designers | 2 | SY-1, SY-2 |
| 5 | Level Designers | 3 | LV-1..3 |
| 6 | Physics & Traversal Designers | 2 | PH-1, PH-2 |
| 7 | Economy / Progression Designers | 2 | EC-1, EC-2 |
| 8 | Narrative Directors | 2 | NA-1, NA-2 |
| 9 | Comedy & Game Writers | 2 | WR-1, WR-2 |
| 10 | Lead Architects | 2 | AR-1, AR-2 |
| 11 | Gameplay Programmers | 2 | PR-1, PR-2 |
| 12 | Network Engineers | 2 | NE-1, NE-2 |
| 13 | Build / DevOps | 1 | DO-1 |
| 14 | Technical Artists | 2 | TA-1, TA-2 |
| 15 | Art Directors | 2 | AD-1, AD-2 |
| 16 | Environment / 3D Artists | 2 | EN-1, EN-2 |
| 17 | VFX Artists | 2 | FX-1, FX-2 |
| 18 | Animation Leads | 2 | AN-1, AN-2 |
| 19 | Lighting Artist | 1 | LT-1 |
| 20 | Audio Director & Sound Designers | 3 | AU-1..3 |
| 21 | UX / UI Designers | 2 | UX-1, UX-2 |
| 22 | Accessibility Specialist | 1 | AX-1 |
| 23 | QA Leads | 2 | QL-1, QL-2 |
| 24 | Senior QA Testers | 3 | QA-1..3 |
| 25 | Market & Community Critics | 3 | MC-1..3 |
| | **TOTAL** | **50** | |

## 2. Methodology

Three sequential rounds, each a full-board play-and-critique of the design against the live build target. Every finding gets an ID (`R{round}-{area}-{n}`), a **severity** (Blocker / Major / Minor / Polish), an owner group, and a **resolution** carried into the v2.0 docs. Each round closes with a **Fun Confidence** vote (1–10) and a go/no-go to the next round.

- **Round 1 — Foundations & Fun Audit (macro):** Is the loop fun for 10 hours? Where is depth thin? Pillar adherence, market fit, the "why do we keep playing?" question.
- **Round 2 — Systems Depth, Humor & Juice (meso):** Concrete system design — contraption depth, progression/meta, the comedy engine, game-feel/juice, level design, onboarding, network feel.
- **Round 3 — Cohesion, Risk & Ship-Readiness (micro + holistic):** Balance, accessibility, performance, review-score risk, edge cases, and the final green-light.

---

## 3. ROUND 1 — Foundations & Fun Audit

**Fun Confidence going in: 7.4 / 10.** Verdict: strong core, but depth and "engagement architecture" under-specified for 10 hours; humor is asserted, not yet *engineered*.

| ID | Area | Sev | Critique | Resolution (in v2.0) |
|---|---|---|---|---|
| R1-LOOP-1 | Core loop | Major | Loop is a flat "haul A→B" repeated; no escalating goal structure to pull players across 10h. | Introduced **Haul Contracts** + per-biome **Boss-Haul** finale and a meta "Union Ladder" (docs 01, 09, 13). |
| R1-DEPTH-2 | Depth | Blocker | "~10h" was a table, not a designed curve. No hour-by-hour plan. | New **Content & 10-Hour Pacing** doc (09) maps every hour, contract, and unlock. |
| R1-FUN-3 | Fun | Major | Comedy relies on emergent physics alone; no systems guarantee laughs each session. | New **Humor & Comedy Design** doc (11): Disaster Cam, Blooper Reel, emote/voice engine, cargo personalities. |
| R1-FEEL-4 | Game feel | Major | "Juice" mentioned once. Impact/feedback unspecified — fatal for a physics-comedy. | New **Game Feel & Juice** doc (10): hit-stop, screen shake, squash/stretch, VFX/SFX layering, haptics spec. |
| R1-ENGAGE-5 | Engagement | Major | No reason-to-return loop (dailies/goals/identity). | Added **Foreman's Challenges** (daily/weekly), **crew identity/cosmetics**, **Workshop sharing** (docs 12, 17). |
| R1-CONTRA-6 | Contraption | Major | Module list is small; building is "assemble," not "express." | **Blueprint Garage** with snap-grid building, save/share, and ~40 modules across 5 classes (docs 01, 13). |
| R1-PROG-7 | Progression | Major | "Scrip → unlocks" lacks structure, pacing, and identity rewards. | Full **Economy/Progression/Meta** doc (12): Scrip + Sprockets, Union Ranks, prestige, unlock cadence. |
| R1-MModes-8 | Modes | Minor | Single mode limits longevity. | Added **Story-lite Campaign (Contracts)**, **Endless "The Long Haul"**, **Daily Gauntlet** (docs 01, 09). |
| R1-NAR-9 | Narrative | Minor | World is charming but thin; no hook to bind biomes. | Expanded narrative bible (07): the Union arc, rival Greasewheels, cargo characters, 80+ barks. |
| R1-MKT-10 | Market | Minor | Capsule/clip strategy absent; discovery is the #1 risk. | New **Marketing & Steam Page** doc (18): capsule, GIF/clip funnel, Next Fest, creator program. |
| R1-ONB-11 | Onboarding | Minor | "60-second tutorial" undefined; co-op onboarding is hard. | New **UX/UI & Onboarding** doc (15): the "First Hill" guided haul + contextual coaching. |
| R1-SCOPE-12 | Scope | Polish | Risk that depth additions bloat scope/cost. | All additions are **systemic & content-light** (reuse the haul loop); scope guarded in doc 03. |

**Round 1 close — Fun Confidence: 7.4 → (target after fixes) 8.6. Decision: PROCEED.** Major structural gaps (depth curve, humor engine, juice, meta) assigned. Creative Director note: *"The core is a hit; we were shipping a great toy without a great game around it. Build the game around the toy."*

---

## 4. ROUND 2 — Systems Depth, Humor & Juice

**Fun Confidence going in: 8.6 / 10.** Verdict: structure now exists; refine the systems so every minute is funny, fair, and escalating.

| ID | Area | Sev | Critique | Resolution (in v2.0) |
|---|---|---|---|---|
| R2-CONTRA-1 | Contraption | Major | Stations vs hands triage is great, but no "build identity." Add archetypes & light perks. | Module **classes with trade-off identities** + optional **Crew Perks** (sidegrade) (docs 01, 12). |
| R2-HUMOR-2 | Humor | Major | Need authored comedy beats, not just emergent. | **Calamity Events** (scripted-but-physical set-pieces), **cargo screams/reactions**, **gravestone last-words** (docs 11, 13). |
| R2-FEEL-3 | Game feel | Major | Grab/winch/strain feedback must be best-in-class. | Spec'd **winch tension curve + audio + rumble**, **grab snap & squash**, **strain telegraph** 3-stage (doc 10). |
| R2-CLIP-4 | Shareability | Major | Virality requires frictionless clipping. | **Replay Theater + one-click clip export + Photo Mode**; auto-bookmark disasters (docs 10, 11, 15). |
| R2-LV-5 | Level design | Major | Biomes need signature mechanics, not reskins. | Each biome gets a **signature system + set-piece + Boss-Haul** (doc 13, fully detailed per biome). |
| R2-DIFF-6 | Difficulty | Major | No difficulty/onboarding-to-mastery curve; risk of frustration or boredom. | **Adaptive route choice (safe/risky)** + **Mutator deck** + tunable assists; mastery via "Perfect Haul" tiers (docs 09, 12). |
| R2-NET-7 | Networking | Major | Emotes, replay capture, blueprint sync, mutator seeds need a net plan. | TDD v2 (02): networked emotes, host-recorded replay, deterministic mutator seeds, blueprint sync, late-join. |
| R2-ECON-8 | Economy | Minor | Reward pacing risk: too fast = empty; too slow = grind. | **Dual currency + smoothed unlock curve** with first-session "taste" unlocks (doc 12). |
| R2-AUD-9 | Audio | Major | Audio is the comedy timing engine; under-specified. | New **Audio & Music** doc (14): adaptive layers, strain stems, proximity voice, comedic stingers, mix bus plan. |
| R2-UX-10 | UX | Minor | HUD must stay minimal but convey strain, ping, voice, roles. | UX doc (15): diegetic-first HUD, ping wheel, emote wheel, role tags, end-of-run "story card." |
| R2-ANIM-11 | Animation | Minor | Ragdoll comedy needs authored flavor (faces, catches, flails). | Animation standards (docs 05, 10): expressive faces, active-ragdoll catches, celebration/fail sets. |
| R2-ACC-12 | Accessibility | Minor | Physics comedy can exclude; needs deep options. | New **Accessibility** doc (16): assists, motion/photosensitivity, one-hand, captions, colorblind. |
| R2-LIVE-13 | Live-ops | Minor | Longevity beyond launch undefined. | New **Live-ops & Post-Launch** doc (17): seasons, free biome drops, community Gauntlets, Workshop. |

**Round 2 close — Fun Confidence: 8.6 → 9.2. Decision: PROCEED.** Game Directors note: *"Now it's funny on purpose and deep on purpose. Lock feel and cohesion next."*

---

## 5. ROUND 3 — Cohesion, Risk & Ship-Readiness

**Fun Confidence going in: 9.2 / 10.** Verdict: ensure the pieces sing together, kill review-score risks, confirm scope.

| ID | Area | Sev | Critique | Resolution (in v2.0) |
|---|---|---|---|---|
| R3-BAL-1 | Balance | Major | Mutators/perks could break fairness across skill levels. | All power = **sidegrade**; mutators are opt-in score-multipliers; perks cosmetic-adjacent. Balanced tables in doc 12. |
| R3-FRUST-2 | Frustration | Major | Repeated wipeouts could feel punishing, tanking reviews. | **Generous checkpoints, payload "chip" not "shatter," comedic framing of failure, assist toggles** (docs 01, 10, 16). |
| R3-PERF-3 | Performance | Major | Replay capture + many rigidbodies + VFX risk Deck perf. | Budgets + pooling + replay LOD + mutator body caps in TDD v2 (02) and QA perf gates (06). |
| R3-NETEDGE-4 | Net edge cases | Major | Host migration absent; late-join into chaos; desync of replay. | Documented limits + **graceful run-end, safe late-join, host-recorded replay only** (02). |
| R3-CLARITY-5 | Readability | Minor | More systems risk clutter; readability pillar at risk. | Diegetic-first feedback, strict HUD budget, colorblind hazard language (docs 10, 15, 16). |
| R3-ONB-6 | Onboarding | Minor | New players in a 4-stack can feel lost. | Role-suggestion on first run, contextual tips, "copilot" assist for solo/duo (docs 15, 09). |
| R3-LOC-7 | Localization | Minor | Humor must survive translation. | Visual-first comedy, ≤12-word barks, loc notes; 8-language text plan (docs 07, 14, 18). |
| R3-SCOPE-8 | Scope/cost | Major | Confirm the v2.0 spec is still "cheap & fast." | Verified: additions reuse one physics loop + asset-store art; vertical slice unchanged (doc 03). |
| R3-MKT-9 | Discovery | Major | 60+ games/day; must engineer the wishlist funnel. | Capsule A/B, 6 hero GIFs, demo-in-Next-Fest, creator keys, "clip-to-wishlist" loop (doc 18). |
| R3-QA-10 | QA | Minor | Need to test *fun*, not just function. | QA v2 (06): "Laugh Audit," clip-ability test, first-session funnel, fun-metric telemetry. |
| R3-SIGN-11 | Sign-off | — | Final green-light gate. | **All groups signed off.** See §6. |

**Round 3 close — Fun Confidence: 9.2 → 9.4. Decision: GREEN-LIT.**

---

## 6. Consolidated outcome — what changed for v2.0

1. **Depth architecture:** Haul Contracts → per-biome Boss-Haul → Union Ladder; three modes (Contracts / Endless / Daily Gauntlet). *(docs 01, 09)*
2. **A designed 10-hour curve:** hour-by-hour pacing, unlock cadence, and “reasons to return.” *(doc 09)*
3. **An engineered comedy engine:** Disaster Cam, Blooper Reel, emote/voice/cargo reactions, Calamity Events, gravestone quips. *(doc 11)*
4. **Best-in-class game feel:** full juice spec — hit-stop, shake, squash/stretch, winch/strain feedback, haptics, VFX/SFX. *(doc 10)*
5. **Real progression & identity:** dual currency, Union Ranks, ~40 modules, Blueprint Garage, cosmetics, prestige. *(doc 12)*
6. **Signature level design:** each of 6 biomes detailed with a unique system + set-piece + Boss-Haul. *(doc 13)*
7. **Full supporting specs:** Audio/Music (14), UX/UI & Onboarding (15), Accessibility (16), Live-ops (17), Marketing/Steam (18); plus TDD/Implementation/Asset/Art/QA/Narrative all re-authored to v2.0.

## 7. Final Fun-Confidence trajectory

| Round | Theme | Confidence |
|---|---|---|
| Pre-review | v1.0 baseline | 7.4 |
| After R1 | structure & depth assigned | 8.6 |
| After R2 | humor, feel, systems designed | 9.2 |
| After R3 | cohesion, risk, ship-readiness | **9.4** |

**Board sign-off:** Creative Director, 2× Game Directors, Design, Narrative, Engineering, Art, Audio, UX, Accessibility, QA Leads, and Market Critics — **unanimous green-light** to publish the v2.0 documentation set and proceed to the Phase 3 vertical slice.

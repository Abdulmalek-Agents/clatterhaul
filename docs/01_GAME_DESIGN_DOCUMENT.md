# Clatterhaul — Game Design Document (GDD)

**Version:** 2.0 (post 3-round senior review — see `08_REVIEW_AND_CRITIQUE_LOG.md`)  ·  **Owner:** Game Design  ·  **Engine:** Unity 6000.4.4f1 / URP  ·  **Net:** Mirror + Steam P2P

> v2.0 changelog: added modes, Haul Contracts, per-biome Boss-Hauls, the Blueprint Garage, crew identity & perks, Calamity Events, and pointers into the new specialist docs (Feel 10, Humor 11, Economy 12, Levels 13, Audio 14, UX 15, Access 16, Live-ops 17, Marketing 18). The 10-hour curve is now designed in doc 09.

---

## 1. Vision statement

Clatterhaul is the game your friend group keeps coming back to on a Friday night. 2–4 players share one ridiculous, breakable machine and a payload they must *not* drop, and haul it across a hostile, hilarious world. The fun is not in *winning cleanly* — it's in the gloriously stupid ways you almost don't. **Every run is a story; every clip is an ad; every session ends with "one more haul."**

## 2. Design pillars (the five commandments)

1. **Shared piloting, shared blame.** No one player controls the contraption. Success demands constant, loud coordination — the engine of both comedy and triumph.
2. **Readable physics, unpredictable outcomes.** Players always *understand why* (so they improve) yet can never fully *predict* (so it stays funny). Feedback is engineered (doc 10).
3. **Forgive the player, punish the machine.** Players ragdoll, laugh, and recover. The contraption and the clock take the damage. Failure is a setback and a punchline — never a humiliation.
4. **Every session is a highlight reel.** Proximity voice + expressive ragdolls + Disaster Cam + one-click clips make moments inherently shareable (docs 10, 11).
5. **Drop-in, drop-out, drop-everything.** Onboarding < 60 seconds; a friend can join mid-session; controls are one-thumb simple, mastery is deep.

## 3. Target audience & market fit

- **Primary:** 18–34 friend groups of 2–4 who buy cheap co-op games together and play on Discord. Direct overlap with PEAK, R.E.P.O., Lethal Company, Content Warning, Human Fall Flat.
- **Secondary:** streamers/creators (high clip-density) and couples/duos.
- **Fit:** sub-$13 impulse price, group-buy friendly, proximity-chat native, Steam Deck verified, Remote Play Together enabled.

## 4. The three nested loops

**Micro (seconds):** read terrain → call it out → act (steer/pedal/crank/brace) → react to the wobble → recover/celebrate.

**Macro (a run, 8–20 min):** Prep in Garage → Depart → Haul legs punctuated by **Hazards & Calamity Events** → **Boss-Haul** (biome finale) → Extraction → Payout & Blooper Reel.

**Meta (across sessions, 10h+):** earn Scrip & Sprockets → climb the **Union Ladder (ranks)** → unlock modules/biomes/cosmetics/mutators → build & share blueprints → chase Perfect Hauls, Foreman's Challenges, and the Daily Gauntlet leaderboard. (Full curve: doc 09; economy: doc 12.)

## 5. Modes

| Mode | Description | Role |
|---|---|---|
| **Contracts (Campaign-lite)** | Ordered set of hand-tuned hauls across 6 biomes, each ending in a Boss-Haul. The spine of the ~10h. | Onboarding → mastery |
| **Endless — "The Long Haul"** | Procedurally chained legs with escalating mutators; how far/clean can you get? | Replay / leaderboards |
| **Daily Gauntlet** | One fixed seed + mutator set for everyone that day; global + friends leaderboards. | Daily return hook |
| **Free Play / Custom** | Pick biome, mutators, payload; sandbox + Workshop blueprints. | Creativity / streams |

## 6. The contraption (signature system)

A **physics body of modular parts** joined by configurable joints, assembled in the **Blueprint Garage** (snap-grid editor; save/share blueprints — doc 15).

### 6.1 Module classes (~40 modules total at launch; all **sidegrades** — doc 12)
| Class | Examples | Trade-off identity |
|---|---|---|
| **Chassis** | Flatbed, Cradle, Cage, Sled | mount type → weight, balance, payload exposure |
| **Locomotion** | Wheels, Mono-wheel, Mech-Legs, Tank-Tracks, Paddle-wheel, Skis | speed vs grip vs terrain fit |
| **Lift/Assist** | Balloon, Sail, Crane-arm, Winch, Spring-jack, Rocket-puff | vertical/tow help vs instability |
| **Stabilizer** | Outriggers, Gyro, Ballast, Counter-weight | safety vs speed/weight |
| **Cosmetic** | Paint, horns, flags, hats, decals, googly-eyes | none (monetization-safe) |

### 6.2 Stations & physics-hands
- **Stations:** networked, hand-off-able control points (steering yoke, pedal, crane lever, sail rope, winch crank). One player each.
- **Physics-hands:** anyone off-station has grab-hands (Human-Fall-Flat feel) to brace cargo, hold a snapping rope, push, or catch a teammate.
- **The core tension:** *always more useful jobs than hands.* Crews triage in real time — the wellspring of banter and blame.

### 6.3 Payload ("the Cargo")
A fragile, high-value, **personality-bearing** object (doc 11) with a **condition meter** that *chips* (never instantly shatters — R3-FRUST-2). Impacts, tipping, submersion, heat/cold chip it. Final payout scales with surviving condition → the "protect the precious idiot thing" drama. 12+ cargo types, each with reactions and a quirk (e.g., the Reactor-Cat purrs when safe, the Chandelier tings on every bump).

## 7. Hazard & event design

- **Static terrain hazards:** ravines (winch/crane), mud (bogs wheels), ice (low friction), narrow ledges, collapsing bridges, gusty gaps.
- **Dynamic events:** wind gusts (vs balloon/sail), rockslides, rising water, non-lethal fauna nuisances (the RV-There-Yet? wildlife-pressure laugh).
- **Calamity Events (NEW):** scripted-but-physical mid-haul set-pieces with a telegraph → spike → resolution rhythm (e.g., "The Avalanche," "Bridge of Sighs," "Neon Rush Hour"). One signature Calamity per biome (doc 13).
- **Design rule:** every hazard has **≥ 2 valid co-op solutions** — reward creativity, never memorization.

## 8. Boss-Hauls (biome finales — NEW)

Each biome ends in a **Boss-Haul**: a multi-stage signature obstacle that demands the biome's mechanic + full-crew coordination (e.g., Canyon's "The Collapsing Mesa," Glacier's "The Calving Glacier"). Completing it banks the contract, awards a cosmetic, and unlocks the next biome. (Full designs: doc 13.)

## 9. Crew identity & perks (NEW, sidegrade)

- **Crew customization:** body, outfit, hat, emote set, voice pitch — self-expression, no power.
- **Perks (optional, sidegrade):** small situational trade-offs (e.g., "Sure Grip": +grab hold, −move speed). Off by default; never strictly better; balanced in doc 12 so any mix can play fairly together (protects review score, R3-BAL-1).

## 10. Content & depth to ~10 hours

The full hour-by-hour curve, contract list, and unlock cadence live in **`09_CONTENT_AND_10_HOUR_PACING.md`**. Summary: 6 biomes × multiple Contracts + Boss-Hauls (~6h first clear) + Endless/Daily/Workshop + mastery (Perfect Hauls, ranks, cosmetics) push well past 10h of engaged play, with **replayability — not raw length — as the retention engine.**

## 11. Game feel, humor & audio (pointers)

These are first-class systems with dedicated docs: **Game Feel & Juice (10)**, **Humor & Comedy Design (11)**, **Audio & Music (14)**. The GDD mandates: every impact has hit-stop+shake+squash+SFX; every disaster is auto-captured for clipping; every session produces at least one authored laugh.

## 12. Multiplayer design (summary; full TDD doc 02)

- **Host-authoritative**, 2–4 players, friends-first via Steam lobbies; the host simulates physics, clients send input + interpolate.
- **Join flow:** Steam invite → lobby → ready → depart. Drop-in in hub; safe late-join at next checkpoint.
- **Proximity voice** is a first-class comedy-delivery feature.
- **No host migration at launch** (documented limit); run ends gracefully if host leaves.

## 13. Camera, controls, UX (summary; full doc 15)

Cinemachine 3 third-person with smart framing + auto **Disaster Cam** slow-mo; Input System (gamepad + KB/M); one-button grab, context interact, **ping wheel**, **emote wheel**; minimal diegetic-first HUD; end-of-run **Story Card** + Blooper Reel.

## 14. Accessibility (summary; full doc 16)

Colorblind-safe hazards, captions, remap, sticky-grab assist, motion/photosensitivity options, one-hand & co-pilot assists, adjustable difficulty via route + mutator choice.

## 15. Monetization & pricing

Premium one-time **$9.99–$12.99**, no pay-to-win. Optional post-launch **cosmetic** packs; free content drops (doc 17). **Friend-pass** consideration (one buys, invite a friend for a trial leg) modeled on Split Fiction goodwill.

## 16. MVP / vertical slice scope (unchanged — protects cost)

Canyon biome, 6–8 modules, 1–2 payloads, 3 hazards + 1 Calamity + the Canyon Boss-Haul, 2–4p networked, proximity voice, Disaster Cam, full Prep→Haul→Extract→Payout loop. All other content reuses these systems (scope guarded in doc 03).

## 17. Success metrics (target)

- **≥95% positive** Steam reviews (target 99% band); near-zero "frustrating/unfair" reviews.
- **Median session ≥ 40 min**, ≥ 3 sessions/week for active groups; **D7 retention ≥ 35%** for groups.
- **≥ 1 shared clip per 2 sessions** (virality proxy); wishlist→sale fueled by a Next-Fest demo (doc 18).

## 18. References / comps

PEAK, RV There Yet?, Human Fall Flat, Lethal Company, Content Warning, Overcooked, Moving Out, Snowrunner (terrain feel), Gang Beasts (ragdoll comedy).

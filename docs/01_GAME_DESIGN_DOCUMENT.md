# Clatterhaul — Game Design Document (GDD)

**Version:** 3.0 (Cycle-2 review — see `19_REVIEW_CYCLE_2_V3.md`)  ·  **Owner:** Game Design  ·  Unity 6000.4.4f1 / URP  ·  Mirror + Steam P2P

> v3.0 integrates the **production-data layer**: this GDD is the design intent; concrete numbers/content live in the bibles — Content Manifest (20), Modules (21), Cargo (22), Mutators (23), Barks (24), First-90 (25), Balance (26), Test-Cases (27). v2.0 design (pillars, systems, feel/humor) is unchanged and reaffirmed.

## 1. Vision
Clatterhaul is the game your friend group keeps coming back to. 2–4 players share one ridiculous, breakable machine and a payload they must *not* drop, hauling it across a hostile, hilarious world. **Every run is a story; every clip is an ad; every session ends with "one more haul."**

## 2. Design pillars
1. **Shared piloting, shared blame.** 2. **Readable physics, unpredictable outcomes.** 3. **Forgive the player, punish the machine.** 4. **Every session is a highlight reel.** 5. **Drop-in, drop-out, drop-everything.** (Feel engineered in doc 10; comedy in doc 11.)

## 3. Audience & fit
18–34 friend groups of 2–4 (PEAK/R.E.P.O./Lethal Company/Human Fall Flat overlap); streamers; couples. Sub-$13, proximity-chat native, Deck verified, Remote Play.

## 4. Three nested loops
- **Micro (s):** read terrain → call it → act → react → recover/celebrate.
- **Macro (run 8–20m):** Prep → Depart → Haul legs + Hazards/Calamity → **Boss-Haul** → Extract → Payout + Blooper. Full leg specs: **doc 20**.
- **Meta (10h+):** Scrip/Sprockets → **20 Union Ranks** + prestige → unlock ~40 modules/biomes/cosmetics/mutators → build & share blueprints → Perfect Hauls, Challenges, Daily. Numbers: **docs 12, 26**.

## 5. Modes
**Contracts** (campaign-lite spine, ~6.5h — doc 20) · **Endless "The Long Haul"** (escalating mutators — doc 23) · **Daily Gauntlet** (shared seed, leaderboards — docs 23/26) · **Free/Custom** (sandbox + Workshop).

## 6. The contraption (signature system)
Modular physics body assembled in the **Blueprint Garage** (snap-grid; save/share — doc 15). **40 modules across 5 classes, all sidegrades** — full datasheet in **doc 21**. **Stations + physics-hands** create the "more jobs than hands" triage. **Cargo** (12 types, condition *chips* not shatters, each a comedy character) — **doc 22**.

## 7. Hazards, Calamities & Boss-Hauls
Static + dynamic hazards (≥2 solutions each); one signature **Calamity** per biome (telegraph→spike→resolve); each biome ends in a multi-stage **Boss-Haul**. All specified per-leg in **docs 13 & 20**.

## 8. Crew identity & perks
Customization (body/outfit/hat/emote/voice) + optional sidegrade **perks** (off by default). No power advantage (doc 12).

## 9. Content & 10-hour depth
34 hand-tuned hauls (22 Contracts + 6 Boss + 6 Calamity) → ~6.5h first clear; Endless/Daily/Workshop/mastery push past 10h. Curve in **doc 09**; manifest in **doc 20**; onboarding in **doc 25**.

## 10. Feel, humor, audio
First-class systems: **Game Feel (10)**, **Humor (11)**, **Audio (14)**. Mandate: every impact = hit-stop+shake+squash+SFX; every disaster auto-clips; **≥1 authored laugh / ~90s** (doc 20/25).

## 11. Multiplayer
Host-authoritative, 2–4p, Steam lobbies, proximity voice; safe late-join; no host-migration at launch (graceful end). Full TDD: **doc 02**.

## 12. Camera / controls / UX / accessibility
Cinemachine + Disaster-Cam; one-button grab, ping & emote wheels; diegetic-first HUD; First Hill onboarding (doc 15); full accessibility suite (doc 16).

## 13. Monetization
Premium $9.99–$12.99, no pay-to-win; cosmetic-only post-launch (doc 17); friend-pass consideration.

## 14. MVP / vertical slice (unchanged)
Canyon + 6–8 modules + 1–2 cargo + 3 hazards + 1 Calamity + Canyon Boss-Haul + 2–4p net + voice + Disaster-Cam + full loop. Build plan: **doc 03**.

## 15. Success metrics
≥95% positive (target 99%); median session ≥40 min; D7 ≥35% (groups); ≥1 shared clip / 2 sessions; Next-Fest-fueled wishlists (doc 18).

## 16. v3.0 delta (Cycle-2)
Added the buildable data layer (docs 20–27) and quantified fun density; no scope/system changes (data, not scope). Fun Confidence 9.4 → **9.8**.

## 17. References
PEAK, RV There Yet?, Human Fall Flat, Lethal Company, Content Warning, Overcooked, Moving Out, Snowrunner, Gang Beasts.

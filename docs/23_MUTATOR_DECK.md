# Clatterhaul — Mutator Deck (16 cards)

**Version:** 3.0  ·  **Owner:** Systems Designers  ·  Resolves C2-R1-MUT-4, C2-R2-REPLAY-5, C2-R2-DAILY-8  ·  Balance: doc 26

> Mutators are **opt-in score multipliers** (harder = more points), never passive buffs (R3-BAL-1). Used in **Endless** (escalating chains) and the **Daily Gauntlet** (a fixed seed/set shared by everyone that day). `×` = score multiplier added (multipliers stack additively, capped per doc 26).

| # | Card | Category | Effect | × | Notes |
|---|---|---|---|---|---|
| 1 | Low Gravity | Physics | gravity 0.6×; floatier, bouncier | +0.20 | great clips |
| 2 | Greased Joints | Physics | module joints weaker (break easier) | +0.25 | tension up |
| 3 | Heavy Cargo | Cargo | payload mass 1.5× | +0.20 | handling stress |
| 4 | Glass Cargo | Cargo | payload Frag 1.6× | +0.30 | high risk |
| 5 | Storm | Weather | periodic wind gusts + rain (slippery) | +0.25 | vs balloon/sail |
| 6 | Night | Visibility | reduced light; headlamps only | +0.15 | mood + tension |
| 7 | Fog Bank | Visibility | short sight range | +0.20 | call-outs matter |
| 8 | Gusty | Weather | strong directional wind | +0.20 | Sky synergy |
| 9 | Earthquake | Chaos | periodic ground shudders | +0.25 | timing |
| 10 | Slippery World | Physics | global low friction | +0.25 | ice-everywhere |
| 11 | Sticky Mud | Physics | global drag on locomotion | +0.15 | slow grind |
| 12 | Bouncy World | Physics | high restitution surfaces | +0.20 | chaos comedy |
| 13 | Mirror Controls | Chaos | steering inverted | +0.30 | party chaos |
| 14 | Short Staff | Crew | one station locked (fewer hands) | +0.25 | triage pressure |
| 15 | Rush Hour | Hazard | +50% moving hazards (traffic/fauna) | +0.20 | Neon/Mire synergy |
| 16 | Time Pressure | Pacing | tighter par; faster collapse timers | +0.25 | speed runs |

## Daily Gauntlet rules
- One **UTC-date seed** (Core, Mirror-free — doc 02) selects 1 biome leg + **2–3 mutators** for everyone that day; global + friends leaderboards (cosmetic-only rewards).
- Daily reward: fixed Scrip + a rotating cosmetic shard on first completion; leaderboard tiers grant cosmetic frames (no power).

## Endless ("The Long Haul") rules
- Procedurally chains legs; **every 2 legs adds +1 mutator** from the deck (escalating). Score = Σ(leg payout × (1 + Σ mutator ×)). Personal & friends bests tracked.
- Soft fail = payload destroyed or crew wiped; run banks score earned so far (forgiving).

## Balance guardrails (doc 26)
- Multiplier sum capped (e.g., ×2.5 max) to keep scoring legible.
- Mutators never grant advantage; the funniest/clippiest (Mirror Controls, Bouncy World, Low Gravity) are weighted into Daily rotations for shareability.

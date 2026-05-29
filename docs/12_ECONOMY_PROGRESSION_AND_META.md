# Clatterhaul — Economy, Progression & Meta

**Version:** 2.0  ·  **Owner:** Economy/Progression Designers  ·  Source of R1-PROG-7 / R2-ECON-8 / R3-BAL-1 resolution

> Golden rule (review-score safeguard): **all power is a sidegrade.** Progression sells *identity, variety, and goals* — never raw advantage. Any crew of any rank can play together fairly.

## 1. Currencies

| Currency | Earned from | Spent on |
|---|---|---|
| **Scrip** (soft, frequent) | every haul (payload value + bonuses) | modules, basic cosmetics, mutator cards |
| **Sprockets** (rare, milestone) | Boss-Hauls, Perfect Hauls, weekly challenges | premium cosmetics, prestige paints, blueprint slots |

No real-money currency in core loop. Optional post-launch cosmetic DLC is direct-purchase, not gacha (doc 17).

## 2. Union Ranks (the ladder)

20 ranks. Each rank grants a guaranteed reward (cosmetic and/or module unlock and/or mutator card) so leveling always *gives a toy*. Rank XP comes from haul completion, with bonuses for Perfect Hauls and challenges. After Rank 20: **Prestige** ("Master Tinker") → prestige cosmetics + a Foreman's-Union badge; resets a cosmetic track, never gameplay.

| Rank band | Drip |
|---|---|
| 1–5 | core modules (1 per rank) + starter cosmetics |
| 6–12 | class-defining modules, first mutator cards, emotes |
| 13–20 | cosmetic-heavy, blueprint slots, prestige unlock |

## 3. Module economy (~40 modules; sidegrade matrix)

Each module is defined by a **trade-off vector** (speed / grip / stability / lift / weight / fragility-to-payload). Examples:

| Module | + | − |
|---|---|---|
| Tank-Tracks | grip, stability | speed, turn radius |
| Mono-wheel | speed, agility | stability (tips easily — comedy!) |
| Balloon | lift, soft landings | wind-vulnerable, slow |
| Gyro | anti-tip | weight, Scrip cost |
| Spring-jack | self-righting recovery | cooldown, launch chaos |

Balance target: no single "meta" build wins all biomes; each biome rewards different vectors (doc 13). QA balance pass tracks win/clean-rate per build per biome (doc 06).

## 4. Cosmetics (the real long-tail)

60+ at launch: paints, decals, horns, flags, hats, googly-eyes, crew outfits, emote sets, voice pitches, contraption "nameplates," and Boss-Haul trophy ornaments. Earned via ranks, challenges, Perfect Hauls, and seasonal events. **Cosmetics drive identity & flex — the friend-slop retention engine** without touching balance.

## 5. Goals layer

- **Foreman's Challenges:** 3 daily (small Scrip) + 3 weekly (Sprockets + cosmetic). Examples: "win a Glacier haul using only ice-suitable locomotion," "share a clip," "finish with the Reactor-Cat purring (0 scares)."
- **Perfect Hauls:** per-contract S-tier (0% payload loss + under par time) → trophy cosmetic.
- **Daily Gauntlet leaderboard:** global + friends; cosmetic frames for top tiers (no power).
- **Achievements:** ~40 Steam achievements skewed to *funny* (e.g., "Yard Sale": lose the whole payload in the first 10 seconds).

## 6. Unlock pacing math (anti-grind / anti-empty)

- First session guarantees ≥ 3 unlocks (1 module, 2 cosmetics) in ≤ 30 min.
- Median haul Scrip is tuned so a meaningful unlock is ≤ 1–2 hauls away at all times during Contracts.
- Endless/Daily provide steady Scrip + cosmetic-only chase post-campaign (no power inflation).
- Telemetry guardrails (doc 06): if median time-to-next-unlock > 25 min, payouts are re-tuned.

## 7. Anti-power-creep & fairness (R3-BAL-1)

- Modules = sidegrades; perks = small situational trade-offs, opt-in, off by default.
- Mutators = **opt-in score multipliers** (harder for more points), never passive buffs.
- Mixed-rank crews: the host's biome unlocks gate availability, but *capability parity* is preserved so a Rank 2 friend is never dead weight.

## 8. Economy telemetry (feeds live-ops, doc 17)

Track: Scrip/hour, time-to-next-unlock, module pick-rates per biome, cosmetic equip-rates, challenge completion, prestige rate. Re-balance via data, not vibes.

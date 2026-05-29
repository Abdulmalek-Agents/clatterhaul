# Clatterhaul — Module Datasheet (all 40)

**Version:** 3.0  ·  **Owner:** Systems Designers  ·  Resolves C2-R1-MOD-2  ·  Balance authority: doc 26

> Every module is a **sidegrade** (net-power ≈ 0). Stats on a **−2…+2** scale. Vector: **Spd** speed · **Grp** grip · **Stb** stability · **Lift** · **Wt** weight (higher = heavier/worse handling) · **Rec** self-recovery. Cost = Scrip. Unlock = Rank `Rk` or Boss `B:<id>`. "Fit" = biomes it shines in. Cosmetic class carries **no stats** (identity only).

## Chassis (6) — payload mount; defines weight & exposure
| Module | Spd | Grp | Stb | Lift | Wt | Rec | Cost | Unlock | Fit |
|---|---|---|---|---|---|---|---|---|---|
| Flatbed | 0 | 0 | 0 | 0 | 0 | 0 | starter | Rk1 | all (baseline) |
| Cradle | 0 | 0 | +1 | 0 | +1 | 0 | 400 | Rk2 | fragile cargo |
| Cage | −1 | 0 | +1 | 0 | +1 | +1 | 600 | Rk4 | Mire/Neon (protection) |
| Sled | +1 | −1 | −1 | 0 | −1 | 0 | 700 | Rk5 | Glacier |
| Lowboy | 0 | +1 | +1 | 0 | +1 | −1 | 800 | Rk7 | Canyon/Neon |
| Gimbal-bed | 0 | 0 | +2 | 0 | +1 | +1 | 1200 | B:GL-BOSS | Sky/Mire (self-leveling mount) |

## Locomotion (10) — how it moves
| Module | Spd | Grp | Stb | Lift | Wt | Rec | Cost | Unlock | Fit |
|---|---|---|---|---|---|---|---|---|---|
| Wheels | 0 | 0 | 0 | 0 | 0 | 0 | starter | Rk1 | all |
| Big Wheels | −1 | +1 | +1 | 0 | +1 | 0 | 500 | Rk2 | Canyon/Mire |
| Mono-wheel | +2 | 0 | −2 | 0 | −1 | −1 | 900 | Rk6 | Neon (agile, tippy=comedy) |
| Mech-Legs | −1 | +2 | +1 | 0 | +1 | +1 | 1100 | B:CN-BOSS | Canyon/Sky (climb) |
| Tank-Tracks | −1 | +2 | +2 | 0 | +2 | 0 | 1000 | Rk8 | Mire/Cinder |
| Paddle-wheel | 0 | +1 | 0 | +1 | 0 | 0 | 700 | Rk3 | Mire (water) |
| Skis | +1 | −1 | −1 | 0 | −1 | 0 | 600 | Rk3 | Glacier |
| Hover-pads | +1 | −2 | 0 | +1 | −1 | +1 | 1300 | B:CD-BOSS | Cinder/Sky (no ground grip) |
| Spider-legs | −1 | +2 | +2 | 0 | +1 | +2 | 1400 | B:SK-BOSS | Sky/Canyon (any terrain) |
| Half-track | 0 | +1 | +1 | 0 | +1 | 0 | 800 | Rk5 | Canyon/Mire |

## Lift / Assist (10)
| Module | Spd | Grp | Stb | Lift | Wt | Rec | Cost | Unlock | Fit |
|---|---|---|---|---|---|---|---|---|---|
| Winch | 0 | 0 | 0 | +1 | 0 | +2 | starter | Rk1 | all (recovery) |
| Crane-arm | 0 | 0 | −1 | +2 | +1 | +1 | 450 | Rk1 | Canyon/Neon |
| Balloon | 0 | −2 | −1 | +2 | −1 | +1 | 700 | Rk3 | Mire/Sky (wind-risk) |
| Twin-Balloon | 0 | −2 | 0 | +2 | −1 | +1 | 1000 | Rk9 | Sky |
| Sail | +1 | 0 | −1 | +1 | 0 | 0 | 600 | Rk4 | Sky/Glacier |
| Spring-jack | 0 | 0 | 0 | +1 | 0 | +2 | 750 | Rk4 | all (self-right) |
| Rocket-puff | +2 | 0 | −1 | +1 | 0 | 0 | 1100 | B:MR-BOSS | Cinder (burst) |
| Glider-wing | +1 | 0 | 0 | +1 | −1 | +1 | 1000 | Rk10 | Sky |
| Grapple-line | 0 | +1 | 0 | +1 | 0 | +1 | 850 | Rk6 | Canyon/Sky |
| Jet-fan | +1 | 0 | −1 | +1 | 0 | 0 | 1200 | B:NE-BOSS | Neon/Sky |

## Stabilizer (8)
| Module | Spd | Grp | Stb | Lift | Wt | Rec | Cost | Unlock | Fit |
|---|---|---|---|---|---|---|---|---|---|
| Outriggers | −1 | 0 | +2 | 0 | +1 | 0 | 400 | Rk2 | all |
| Gyro | 0 | 0 | +2 | 0 | +1 | +1 | 900 | Rk5 | Sky/Neon |
| Ballast | −1 | +1 | +1 | −1 | +2 | 0 | 500 | Rk3 | Glacier/Sky |
| Counter-weight | 0 | 0 | +1 | 0 | +1 | +1 | 600 | Rk4 | Canyon |
| Auto-leveler | −1 | 0 | +2 | 0 | +1 | +2 | 1300 | Rk11 | all (assist-friendly) |
| Wide-base | −1 | +1 | +2 | 0 | +1 | 0 | 700 | Rk6 | Mire/Cinder |
| Magnet-feet | −2 | +2 | +2 | 0 | +1 | 0 | 1200 | B:NE-BOSS | Neon (rails) |
| Anchor-spike | 0 | +1 | +1 | 0 | 0 | +2 | 800 | Rk7 | Glacier/Sky (re-anchor) |

## Cosmetic class (no stats; 60+ in doc 12)
Paints, decals, horns, flags, hats, googly-eyes, nameplates, trophy ornaments. Identity only — monetization-safe.

## Balance guardrails (audited, doc 26)
- Sum of each module's vector ≈ 0 (every + has a −). No build dominates all biomes; each biome has counter-vectors (e.g., Glacier punishes low Grp; Sky punishes low Stb/Lift).
- QA tracks **pick-rate & clean-rate per build per biome**; outliers (>60% pick or >80% clean everywhere) get re-tuned (cases in 27).

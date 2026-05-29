# Clatterhaul — Balance & Tuning (numbers)

**Version:** 3.0  ·  **Owner:** Economy/Systems Designers  ·  Resolves C2-R1-BAL-5, C2-R2-PERFECT-6, C2-R2-SOLO-7, C2-R2-DAILY-8  ·  All values are first-pass; tuned by telemetry (doc 06/12).

## 1. Payout formula (per haul)
```
Scrip = round( BasePayout × PayloadFactor × (1 + MutatorMult) ) + TimeBonus + NoLossBonus
  PayloadFactor = 0.4 + 0.6 × (payloadCondition%/100)      // floor 0.4 so failure still pays a little
  TimeBonus     = (underPar ? round(BasePayout × 0.15) : 0)
  NoLossBonus   = (payloadCondition == 100 ? round(BasePayout × 0.10) : 0)
  MutatorMult   = Σ(card×), capped at 1.5  (i.e., max ×2.5 scoring)
```
BasePayout values are per contract in doc 20.

## 2. Sprocket sources (rare currency)
| Source | Sprockets |
|---|---|
| Boss-Haul first clear | +1 (finale +2) |
| Perfect Haul (any contract) | +1 |
| Weekly challenge | +1–2 |
| Rank milestones (5/10/15/20) | +1 each |

## 3. Perfect Haul definition (C2-R2-PERFECT-6)
`payloadCondition == 100%` **AND** `time ≤ par` **AND** `no module lost`. Grants trophy cosmetic + Sprocket + rank XP bonus.

## 4. Rank XP curve (20 ranks)
```
XP(rank n) = round(100 × n^1.45)     // cumulative-per-level
```
| Rank | XP to next | Rank | XP to next |
|---|---|---|---|
| 1→2 | 100 | 11→12 | ~520 |
| 2→3 | 175 | 12→13 | ~590 |
| 3→4 | 245 | 13→14 | ~660 |
| 4→5 | 315 | 14→15 | ~735 |
| 5→6 | 385 | 15→16 | ~810 |
| 6→7 | 410 | 16→17 | ~890 |
| 7→8 | 435 | 17→18 | ~965 |
| 8→9 | 460 | 18→19 | ~1045 |
| 9→10 | 485 | 19→20 | ~1125 |
| 10→11 | 500 | 20→Prestige | ~1200 |
XP per haul ≈ BasePayout/10 + 25 (Perfect +50). Target: Rank 20 ≈ end of Contracts + a little Endless (matches doc 09).

## 5. Par-time guideline
```
Par = ExpectedLegMinutes × 1.15   // 15% headroom over a clean designer run; per-contract pars in doc 20
```

## 6. Unlock-cadence guardrails (anti-grind/empty)
- First session: ≥ 3 unlocks in ≤ 30 min (CN-1 module+cosmetic, CN-2 payout).
- Median **time-to-next-unlock ≤ 20 min** during Contracts; telemetry re-tunes if > 25 (doc 12).
- Cheapest module 400 Scrip; CN-1+CN-2 payouts (300+450) cover it in ≤ 2 hauls.

## 7. Assist values (solo/duo & accessibility — C2-R2-SOLO-7, doc 16)
| Assist | Effect | Default |
|---|---|---|
| Co-pilot auto-balance | empty station auto-corrects tip up to 20°/s | ON for 1–2 players |
| Sticky-grab | grab hold tolerance ×1.5; auto-regrab within 0.3s | optional |
| Slow hazards | moving-hazard speed ×0.8; collapse timers ×1.2 | optional |
| Cargo guard | payload Frag ×0.85 | optional (assist mode) |
Assists never change payout (no stigma, no leaderboard for assisted Daily).

## 8. Mutator scoring (doc 23)
Multipliers stack additively; **cap MutatorMult = 1.5**. Daily picks 2–3 cards (seed) summing ≤ ~0.7. Endless adds +1 card every 2 legs until cap.

## 9. Difficulty knobs (designer-facing SOs)
hazardSpeedScale, collapseTimerScale, payloadFragScale, gustStrength, friction (ice), boggDrag, wind, ember/heat DPS, fauna aggression. Per-biome defaults in doc 13; per-contract overrides in doc 20.

## 10. Economy targets (telemetry)
Scrip/hour ≈ 2500–3500 during Contracts; cosmetic-only chase post-campaign; prestige reachable ~12–16h engaged play. Re-balance from data, never vibes.

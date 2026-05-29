# Clatterhaul — Test-Case Appendix (enumerated)

**Version:** 3.0  ·  **Owner:** QA Leads + Senior QA  ·  Resolves C2-R1-QA-8  ·  Complements the matrix in doc 06.

> Runnable cases: ID · area · steps · expected. Severity of a failure follows doc 06. "P" cases are pass/fail; "M" cases are metric thresholds (fun/perf).

## Networking
| ID | Steps | Expected |
|---|---|---|
| NET-01 | Host a lobby; invite 3 via Steam | all 4 join < 10s; see/hear each other |
| NET-02 | Client joins mid-hub | spawns cleanly, no desync |
| NET-03 | Join mid-haul | spectate to next checkpoint, then spawn |
| NET-04 | Host leaves mid-run | graceful run-end + banked payout; no crash |
| NET-05 | Sim 300ms + 2% loss | rig remains controllable; interpolation smooth |
| NET-06 | Trigger emote on client | replicated to all via RPC |
| NET-07 | Daily seed on 4 machines | identical mutators/leg (Core determinism) |

## Physics / feel
| ID | Steps | Expected |
|---|---|---|
| FEL-01 | Grab a crate | spring-joint + snap SFX + rumble; elastic feel |
| FEL-02 | Hard impact | hit-stop + shake + squash + VFX + SFX fire (doc 10) |
| FEL-03 | Winch to limit | tension curve audio/visual + pre-snap ping |
| FEL-04 | Stress a joint to 3 stages | creak → groan+sparks → snap+Disaster-Cam |
| FEL-05 | Catastrophic tip | Disaster-Cam slow-mo + auto-bookmark for clip |

## Run / modes / economy
| ID | Steps | Expected |
|---|---|---|
| RUN-01 | Finish CN-2 at 100% under par | payout = base + TimeBonus + NoLossBonus (doc 26) |
| RUN-02 | Finish with 50% payload | PayloadFactor=0.7 applied; partial payout |
| RUN-03 | Clear CN-BOSS | +900 Scrip +1 Sprocket; Glacier unlocks; trophy granted |
| RUN-04 | Hit a checkpoint then fail | restart at checkpoint, no progress lost |
| RUN-05 | Endless 4 legs | +1 mutator added at legs 2 & 4; score uses cap |
| RUN-06 | Rank-up at threshold | XP matches curve (doc 26); reward granted |
| RUN-07 | Perfect Haul on CN-2 | trophy + Sprocket + XP bonus; flagged S-tier |

## Garage / blueprint
| ID | Steps | Expected |
|---|---|---|
| GAR-01 | Build + save a blueprint | persists; reloads identical |
| GAR-02 | Load blueprint at depart | host instantiates & validates connectivity/mass |
| GAR-03 | Load an unstable/broken blueprint | validation flags; safe fallback rig used |
| GAR-04 | Share & download a blueprint | round-trips via Workshop/string intact |

## Hazards / Calamity / Boss
| ID | Steps | Expected |
|---|---|---|
| HAZ-01 | Each hazard in a leg | ≥ 2 valid co-op solutions confirmed |
| HAZ-02 | Trigger a Calamity | telegraph → spike → resolve; no instant unfair loss |
| HAZ-03 | Boss-Haul stages | 3 readable stages; generous checkpoints; triumphant exit |

## Clip / photo / replay
| ID | Steps | Expected |
|---|---|---|
| CLP-01 | Export last 30s | MP4/GIF saved; off-thread; no frame hitch |
| CLP-02 | Open Replay Theater | scrub + free-cam; disasters bookmarked |
| CLP-03 | Photo Mode | filters/FOV/hide-HUD work; pause-safe |

## Performance (M)
| ID | Steps | Threshold |
|---|---|---|
| PRF-01 | 4p Canyon, mid-PC | ≥ 60 FPS @1080p |
| PRF-02 | 4p Canyon, Steam Deck | 40–60 FPS native |
| PRF-03 | Calamity + Disaster-Cam + clip export | no GC spike > 2ms; draw calls < 1500 |

## Accessibility
| ID | Steps | Expected |
|---|---|---|
| ACC-01 | Enable colorblind mode | hazards distinguishable by shape+motion |
| ACC-02 | Reduce-motion preset | shake/slow-mo off; Disaster-Cam → still highlight |
| ACC-03 | One-hand layout | full play possible; no required mashing |
| ACC-04 | Captions on | VO + key SFX captioned with direction |
| ACC-05 | Solo + co-pilot | empty station auto-balances; haul completable |

## Fun metrics (M — Laugh/Feel/Frustration audits, doc 06/11)
| ID | Metric | Threshold |
|---|---|---|
| FUN-01 | genuine laughs / session | ≥ 5 |
| FUN-02 | clip-worthy moments / session | ≥ 2 |
| FUN-03 | "felt unfair" incidents | 0 |
| FUN-04 | new groups reaching CN-BOSS ≤ 90 min | ≥ 80% |
| FUN-05 | authored comedy beat cadence per leg | ≥ 1 / ~90s |

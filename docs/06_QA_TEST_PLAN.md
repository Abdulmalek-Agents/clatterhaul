# Clatterhaul — QA & Environment-Review Test Plan

**Version:** 2.0 (post-review)  ·  **Owner:** Senior QA Testers + QA Leads (with Technical Artist + 3D Modelers)

## 1. QA mandate (elevated)
QA actively **plays every scene in-editor**, reading frame data / Profiler / console; reproduces every reported issue to root cause; assesses **asset placement** to a senior-env-artist standard; validates feel, collision, LOD, shadows, AO; and — new for v2.0 — **tests *fun* explicitly** (Laugh/Feel/Frustration audits). No push to main without QA sign-off.

## 2. Fun-metric audits (NEW)
| Audit | Method | Target |
|---|---|---|
| **Laugh Audit** | observed genuine laughs / session | ≥ 5 |
| **Clip-ability** | clip-worthy moments / session; Disaster-Cam triggers | ≥ 2 |
| **Feel Audit** | doc 10 checklist on every interaction | all pass |
| **Frustration Audit** | "that felt unfair" incidents | 0 |
| **First-session funnel** | % new groups reaching first Boss-Haul | ≥ 80% |

## 3. Functional test matrix
| Area | Cases |
|---|---|
| **Networking** | 2/3/4 join via invite; late-join at checkpoint; client drop; host drop → graceful end; latency 150/300ms; 2% loss; emote/voice sync |
| **Physics/feel** | grab/carry/throw; station hand-off; joint break; tip & recover; payload chip; winch tension; Disaster-Cam capture |
| **Run/modes** | Contracts/Endless/Daily; seeded mutator parity across clients; checkpoint restore; payout; Blooper Reel; gravestone |
| **Garage** | build/save/load/share blueprint; assembly validation; unstable-rig fallback |
| **Hazards/Calamity/Boss-Haul** | ≥2 solutions each; telegraph→spike→resolve; no soft-locks; generous checkpoints |
| **Economy/meta** | Scrip/Sprockets payout; rank-ups; unlock cadence; challenges; leaderboards; cloud save |
| **Clip/Photo/Replay** | export MP4/GIF; photo mode; replay scrub; off-thread perf |
| **Perf** | 1080p60 mid-PC; Deck 40–60; draw calls < 1500; physics ≤ 4ms; no GC spikes; replay/VFX within budget |
| **Accessibility** | remap; one-hand; colorblind; captions; motion/shake/slow-mo toggles; sticky-grab; co-pilot |

## 4. Environment-review checklist (joint QA + Art)
Grounding (no float/clip), pivots, intentional placement, materials (no magenta), clean lightmap UVs (no leaks), smooth LODs, accurate collision, occlusion baked, AO present, organized hierarchy, prefabs for repeats, static flags. Applied per biome before approval.

## 5. Bug report template
```
ID:            CLH-###
Title / Severity (Blocker/Critical/Major/Minor/Polish)
Build/Branch (sha) / Platform (PC|Deck) / Players (1-4)
Repro 1..n / Expected / Actual
Evidence (profiler|log|clip) / Fun-impact (Laugh|Frustration if relevant)
Root cause / Fix (PR) / Status (Open→Verified→Closed)
```

## 6. Phase gates (sign-off to merge)
- Code compiles vs imported packages; EditMode tests green; architecture review passed.
- Vertical slice: full loop 2–4p; perf in budget; **Laugh ≥ 5, Frustration = 0**; environment review green; zero Blocker/Critical open.
- Every push to main: QA sign-off; scene changes also Art/Environment sign-off.

## 7. Tools
Unity Profiler/Frame Debugger, Memory Profiler, ParrelSync, Mirror latency sim, telemetry dashboards (economy/fun proxies), accessibility test rigs, CI EditMode/PlayMode, secret-scan.

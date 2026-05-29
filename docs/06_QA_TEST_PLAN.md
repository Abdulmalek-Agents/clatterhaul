# Clatterhaul — QA & Environment-Review Test Plan

**Version:** 1.0 (Phase 2)  ·  **Owner:** Senior QA Testers (with Technical Artist + 3D Modelers)

## 1. QA mandate (elevated)

QA actively **plays every scene and gameplay segment in-editor**, reading frame data, Profiler stats, and console logs in real time; reproduces every user-reported issue step-by-step to root cause; assesses **asset placement** in every environment (position/rotation/scale, grounding, occlusion, hierarchy) to a senior environment-artist standard; validates gameplay feel, collision accuracy, LOD transitions, shadow casting, and AO before approving any phase; and files structured bug reports tracked to closure.

## 2. Test matrix

| Area | Cases |
|---|---|
| **Networking** | 2/3/4-player join via Steam invite; late-join in hub; client drop; host drop (run ends gracefully); high-latency (sim 150/300ms); packet loss 2% |
| **Physics/feel** | Grab/carry/throw; station hand-off; joint break; contraption tip & recover; payload condition on impact/submersion |
| **Run flow** | Prep→haul→hazard→extract→payout; checkpoint restore; modifier application; daily-seed parity across clients |
| **Hazards** | Each hazard has ≥2 valid solutions; no soft-locks; no out-of-bounds payload loss without feedback |
| **Perf** | 1080p60 mid-PC; Deck 40–60; draw calls < 1500; physics ≤ 4ms; no GC spikes > 2ms |
| **UX/Accessibility** | Rebinding; colorblind hazard markers; captions; sticky-grab toggle; ping wheel |
| **Environment review** | Section 3 checklist on every scene |

## 3. Environment-review checklist (joint QA + Art)

For every scene before approval: grounding (no float/clip), pivots correct, scale/placement intentional, materials assigned (no magenta), clean lightmap UVs (no leaks), LOD transitions smooth, collision accurate, occlusion culling baked, AO present, hierarchy organized, prefabs used for repeats, static flags correct.

## 4. Bug report template

```
ID:            CLH-###
Title:         <concise>
Severity:      Blocker / Critical / Major / Minor / Polish
Build/Branch:  <phase-x / sha>
Platform:      PC / Steam Deck   Players: 1/2/3/4
Repro steps:   1) ... 2) ... 3) ...
Expected:      ...
Actual:        ...
Evidence:      <profiler stat / console log / screenshot / clip>
Root cause:    <when found>
Fix / owner:   <PR link>
Status:        Open / In-progress / Fixed / Verified / Closed
```

## 5. Phase gates (sign-off required to merge)

- **Phase 2 (this):** code stubs compile against imported packages; EditMode tests green; architecture review passed.
- **Phase 3 (Canyon slice):** full loop playable 2–4p; perf within budget; environment-review checklist green; zero Blocker/Critical bugs open.
- Every PR requires QA sign-off; scene-touching PRs also require Art/Environment sign-off.

## 6. Tools

Unity Profiler & Frame Debugger, Memory Profiler, ParrelSync (multi-client), Mirror latency sim, in-editor console assertions, automated EditMode/PlayMode runs in CI (Phase 3).

# Clatterhaul — Art Direction & Environment Standards

**Version:** 1.0 (Phase 2)  ·  **Owner:** Technical Artist + 3D Modelers + Lighting/Environment team (with QA)

## 1. Art direction

- **Style:** stylized low-poly (Synty POLYGON language) with chunky, readable silhouettes — perf-friendly, instantly legible mid-chaos, and cohesive across all 6 biomes for low cost.
- **Readability first:** the contraption, payload, players, and hazards must read clearly at gameplay distance. Hazards use a consistent visual language (warning palette + shape).
- **Comedy through animation, not gore:** expressive ragdolls, squash/stretch on impacts, exaggerated dust.

## 2. Biome palettes & mood
| Biome | Palette | Signature hazard read |
|---|---|---|
| Canyon | warm ochre / rust | crumbling ledges, ravine gaps |
| Swamp/Mire | murky green | bog (slows wheels), gas pockets |
| Glacier | cold blue-white | low-friction ice, crevasses |
| Volcano/Cinder | charcoal + ember orange | heat zones, falling rock |
| Neon City | dark + saturated neon | traffic, electrified rails |
| Sky-Ruins | pastel + gold hour | wind gusts, floating gaps |

## 3. Environment dressing standards (QA-enforced)

Every placed asset must pass the **joint QA + Art/Environment review** before a scene is approved:

- **Grounding:** no floating or sunken props; contact shadows confirm ground contact. No unintended clipping/intersection.
- **Pivots:** pivots at sensible base/anchor points; rotation snaps clean; no off-origin jitter.
- **Scale & placement intent:** every prop placed with artistic purpose (composition, sightlines, leading the eye along the route) — to a senior environment-artist standard, not scattered.
- **Materials:** correct material/variant assigned; no missing (magenta) materials; consistent texel density.
- **Lightmap UVs:** clean, non-overlapping UV2 on static props; no light leaks/seams after bake.
- **LODs:** LOD groups set with sane transitions (no popping at gameplay distance); billboards for distant foliage.
- **Collision:** accurate colliders; no invisible walls except intentional route bounds; payload/contraption never snags on phantom geometry.
- **Occlusion & AO:** occlusion culling baked; ambient occlusion present on grounded props (no "pasted-on" look).
- **Hierarchy:** organized scene hierarchy (`_Environment/Biome/Section/...`); prefabs for repeated dressing; static flags set correctly.

## 4. Lighting & baking

- URP. Bake static lighting per biome; light probes for dynamic props (contraption/players); reflection probes per enclosed area. Validate shadow casting on all hero assets. Performance-first GI settings for Deck.

## 5. Optimization

- SRP Batcher on; GPU instancing for repeated modules; texture atlasing (POLYGON already atlased); debris pooled; aggressive LOD + occlusion culling; static batching for non-moving dressing.

## 6. Pipeline

Greybox (designer) → dress with POLYGON kit (3D modelers) → light/bake (lighting team) → **joint QA+Art review** → fix list → re-review → scene approved → merge.

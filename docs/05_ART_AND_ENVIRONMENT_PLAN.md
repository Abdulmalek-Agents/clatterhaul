# Clatterhaul — Art Direction & Environment Standards

**Version:** 2.0 (post-review)  ·  **Owner:** Art Directors + Technical Artist + 3D/Env + VFX + Animation + Lighting (with QA)

## 1. Art direction
- **Style:** stylized low-poly (Synty POLYGON), chunky readable silhouettes — perf-friendly, legible mid-chaos, cohesive across all 6 biomes for low cost.
- **Readability first:** contraption, payload, players, hazards read at gameplay distance; hazards use a consistent warning palette + shape language (doc 16).
- **Comedy through animation, not gore:** expressive faces, squash/stretch, exaggerated dust, derpy slow-mo falls (docs 10, 11).

## 2. Character & cosmetic art bible (NEW)
- Crew: modular body + outfit + hat + face slots; **googly-eye reaction faces** (panic/triumph/dizzy) via blendshapes or swap-shader.
- Cosmetics (60+): paints, decals, horns, flags, hats, trophy ornaments, nameplates — readable as silhouettes; no pay-to-win visuals that obscure gameplay.
- Cargo "characters" get expressive rigs (Reactor-Cat ears/eyes, Chandelier sway, Fish in tank) tied to reactions (doc 11).

## 3. Comedy animation standards (NEW)
- Active-ragdoll catch/flail/recover sets; celebration & fail emote anims; idle banter poses; cargo reaction anims. Snappy, weighty, cartoon timing.

## 4. Biome palettes & mood
Per-biome palettes and signature reads are specified in the **Level Design & Biome Bible (doc 13)**; lighting team owns mood/exposure per biome.

## 5. Environment dressing standards (QA-enforced, joint review)
Every placed asset must pass the **joint QA + Art/Environment review**:
- **Grounding** (no float/sink/clip; contact shadows), **pivots** sensible, **placement intent** (composition leads the eye/route to senior-env-artist standard), **materials** correct (no magenta, consistent texel density), **clean lightmap UVs** (no leaks/seams), **LODs** smooth (no popping), **collision** accurate (no phantom snags), **occlusion + AO** baked, **hierarchy** organized (`_Environment/Biome/Section/...`), prefabs for repeats, correct static flags.

## 6. VFX style (NEW detail)
Stylized dust/sparks/debris/splash/heat/snow/confetti matching POLYGON; pooled to budget (doc 02); Disaster-Cam-friendly (reads in slow-mo). Strain sparks escalate with the 3-stage telegraph (doc 10).

## 7. Lighting & baking
URP baked GI per biome; light probes for dynamic contraption/players/cargo; reflection probes per area; validate shadow casting on hero assets; no leaks/seams; Deck-first GI settings.

## 8. Optimization
SRP Batcher; GPU instancing on modular kits; atlased POLYGON textures; pooled debris/VFX; aggressive LOD + occlusion culling; static batching for fixed dressing.

## 9. Pipeline
Greybox (designer authors the haul first) → dress with POLYGON kit (3D/env) → VFX + anim pass → light/bake (lighting) → **joint QA+Art review** → fix list → re-review → approved → merge. Function/feel locked before beautification.

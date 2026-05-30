# Clatterhaul — Art Direction & Environment Standards

**Version:** 3.1 (adds studio-owned asset hooks)  ·  **Owner:** Art Directors + Technical Artist + 3D/Env + VFX + Animation + Lighting (with QA)

## 1. Art direction
- **Style:** stylized low-poly (Synty POLYGON), chunky readable silhouettes — perf-friendly, legible mid-chaos, cohesive across all 6 biomes for low cost.
- **Readability first:** contraption, payload, players, hazards read at gameplay distance; hazards use a consistent warning palette + shape language (doc 16).
- **Comedy through animation, not gore:** expressive faces, squash/stretch, exaggerated dust, derpy slow-mo falls (docs 10, 11).

## 2. Character & cosmetic art bible
- Crew: modular body + outfit + hat + face slots; **googly-eye reaction faces** (panic/triumph/dizzy) via blendshapes or swap-shader. **Owned base: BoZo Modular Characters** (chibi) + **Eyes Animator** for procedural faces.
- Cosmetics (60+): paints, decals, horns, flags, hats, trophy ornaments, nameplates — readable as silhouettes; no pay-to-win visuals. **Owned: Colorize** powers paint/palette variants without texture duplication.
- Cargo "characters" get expressive rigs (Reactor-Cat ears/eyes, Chandelier sway, Fish in tank) tied to reactions (doc 11) — **Eyes Animator** + ACS.

## 3. Comedy animation standards
- Active-ragdoll catch/flail/recover sets (**PuppetMaster**, external); celebration & fail emote anims; idle banter; cargo reactions. **Owned: Animation Composer System** layers/sequences these and fires feel VFX/SFX on frames; **City Characters** anim library can be retargeted.

## 4. Biome palettes & mood
Per-biome palettes/signature reads are in the **Level Design & Biome Bible (doc 13)**; lighting team owns mood/exposure. Stylized atmosphere via **owned Lumen Stylized Light FX 2** (god-rays/glow) + **Stylized Weather System** + **Zephyr wind**.

## 5. Environment dressing standards (QA-enforced, joint review)
Every placed asset must pass the **joint QA + Art/Environment review**: **grounding** (no float/sink/clip; contact shadows), **pivots** sensible, **placement intent** (composition leads the eye/route), **materials** correct (no magenta, consistent texel density), **clean lightmap UVs** (no leaks/seams), **LODs** smooth, **collision** accurate, **occlusion + AO** baked, **hierarchy** organized (`_Environment/Biome/Section/...` — enforced with **owned Hierarchy Designer**), prefabs for repeats, correct static flags. **All ⚠ (higher-fidelity) owned packs must first pass the Style-Unification Pass (doc 04 Part 3).**

## 6. VFX style
Stylized dust/sparks/debris/splash/heat/snow/confetti; pooled to budget (doc 02); Disaster-Cam-friendly. Strain sparks escalate with the 3-stage telegraph (doc 10). **Owned VFX sources:** All-In-1 Shader Nodes (outline/dissolve/heat/ice/caustics), Ultimate Mesh FX (fire/ice/dissolve/arc), Realistic Water VFX, Casual RPG VFX (celebration), Screenspace VFX (impact/Disaster-Cam), VoluSmokeFX + UNI VFX (rocket-puff/fireworks).

## 7. Lighting & baking
URP baked GI per biome; light probes for dynamic contraption/players/cargo; reflection probes; validate shadow casting; no leaks/seams; Deck-first GI. **Owned: LightMap Fusion Pro** for the Night mutator + day/night biome switching without re-bake.

## 8. Optimization
SRP Batcher; GPU instancing on modular kits; atlased POLYGON textures; pooled debris/VFX; aggressive LOD + occlusion culling; static batching for fixed dressing.

## 9. Pipeline
Greybox (designer authors the haul first) → dress with POLYGON kit / owned packs (3D/env) → **Style-Unification Pass on ⚠ packs** → VFX + anim pass → light/bake → **joint QA+Art review** → fix list → re-review → approved → merge. Function/feel locked before beautification.

## 10. Studio-owned asset hooks per biome (from doc 04)
| Biome | Primary owned dressing | Owned VFX / weather / feel |
|---|---|---|
| **Canyon** | POLYGON BR (grass/desert terrain + props), Shatter Stone (rocks/rockslide), Harvest Garden (rustic), Urban Abandoned ⚠ (broken roads) | All-In-1 dust/outline, Stylized Weather (clear/dust), Obby hazard scripts |
| **Glacier** | POLYGON BR (snow terrain), Stylized Dungeons ⚠ (ice caves) | Ultimate Mesh FX (ice-freeze), Realistic Water VFX, Stylized Weather (snow), All-In-1 ice shader |
| **Mire/Swamp** | POLYGON BR + Harvest Garden props, Toon Town props | Realistic Water VFX (bog/water), All-In-1 caustics, VoluSmokeFX (gas) |
| **Cinder/Volcano** | Industrial Props ⚠ (metal/pipes), Shatter Stone (debris) | Ultimate Mesh FX (fire), UNI VFX (eruption/rocket-puff), All-In-1 heat-distortion, Lumen fire-glow |
| **Neon Sprawl** | Toon Town, Neon Interior Props ⚠, Modular Cyber Racing Cars, City Pack ⚠ | Lumen neon-glow, Ultimate Mesh FX (rail arcs), Screenspace VFX, Stylized Weather (rain) |
| **Sky-Ruins** | Stylized Dungeons ⚠ (floating ruins), Spline Mesher Pro (chain bridges) | Zephyr wind (gusts/Squall), Lumen god-rays, Stylized Weather (storm) |
| **Contraption** | Industrial Props ⚠ (pipes/gears/tanks), Modular Cyber Racing Cars (wheels/panels), Spline Mesher (cables/ropes) | All-In-1 dissolve/outline, Ultimate Mesh FX (break), strain SFX |
| **Crew & UI** | BoZo (crew) + City Characters anims; Heat UI | Eyes Animator (faces), Colorize (cosmetic paints), Game UI & Puzzle SFX |

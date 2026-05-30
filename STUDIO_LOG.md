# STUDIO_LOG — Clatterhaul

Newest entries on top.

---

## Phase 6 — Studio-owned asset library integration  ·  status: PUSHED TO MAIN ✅

### What happened
- Reviewed the studio's **owned 66-asset library** (Inventix Games orders, May 2026) against Clatterhaul's spec (URP, stylized low-poly, Mirror, physics-comedy).
- **~30 assets map cleanly onto the project**; mapped them by system into `04_UNITY_ASSET_INTEGRATION.md` (Part 1) and per-biome into `05_ART_AND_ENVIRONMENT_PLAN.md` (§10).
- Documented **external packages still required** (Mirror stack, PuppetMaster, FMOD, DOTween, Easy Save 3, a recorder, extra Synty kits), the **Style-Unification Pass** for higher-fidelity packs, and the **not-used list** with reasons.

### Key picks (highlights)
- **Tech/anim:** Character Controller Pro / Traversal Pro (base controller), Animation Composer System, Eyes Animator (faces/cargo), Cutscene Engine, MMFPSE (Mirror reference only).
- **Feel/VFX:** All-In-1 Shader Nodes (outline/dissolve/heat/ice/caustics), Lumen Stylized Light FX 2, Ultimate Mesh FX, Screenspace VFX, Realistic Water VFX, Casual RPG VFX.
- **Weather/wind:** Stylized Weather System, Zephyr Dynamic Wind (sails/balloons/Squall).
- **Environment:** POLYGON Battle Royale (Synty style anchor), Obby Parkour (hazard scripts), Spline Mesher Pro (cables/ropes/bridges), Industrial Props (contraption parts ⚠), Modular Cyber Racing Cars, Shatter Stone, Toon Town, Neon Interior Props ⚠, Urban Abandoned ⚠, Stylized Dungeons, Harvest Garden.
- **Characters/UI/audio:** BoZo Modular (crew), City Characters (anims), Heat Complete Modern UI, Game UI & Puzzle SFX.
- **Tools:** Asset Inventory 4, Hierarchy Designer, Colorize (cosmetic paints), LightMap Fusion Pro.

### Decisions / safeguards
- **Mirror-only** netcode preserved — owned Photon templates (MFPS, Horror MP) excluded; MMFPSE used only as a Mirror reference.
- **No gore/magic/medieval/sci-fi-interior** assets used (genre/tone mismatch).
- **Style-Unification Pass mandatory** on ⚠ higher-fidelity packs before the environment-review gate (keeps one cohesive low-poly world).

### Retry log
- No retryable tool errors this phase.

---

## Phase 5 — Documentation cleanup & dev-readiness  ·  status: MERGED ✅
Trimmed to final dev-ready docs; added Production Bible (00); expanded Content Manifest (20) to full 10h.

## Phase 4 — Senior Review Cycle 2 & Production-Data Layer (v3.0)  ·  status: MERGED ✅
## Phase 3 — Senior Review & Polish (v2.0)  ·  status: MERGED ✅
## Phase 2 — Technical & Assets  ·  status: MERGED ✅
## Phase 1 — Foundation  ·  status: MERGED ✅

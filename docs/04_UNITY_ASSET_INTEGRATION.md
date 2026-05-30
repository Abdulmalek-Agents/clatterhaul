# Clatterhaul — Unity Asset Store & Package Integration Plan

**Version:** 3.1 (adds Studio-Owned Asset Library integration map)  ·  **Owner:** Asset Store Integration + Package/Dependency Experts + Technical Artist

> Every package evaluated for **license compatibility (commercial Steam release), performance cost, and conflict-free integration**. Clatterhaul targets **URP + stylized low-poly + Mirror + physics-comedy**, so picks must match that. v3.1 maps the studio's **owned 66-asset library** (Inventix Games orders, May 2026) onto Clatterhaul's needs and lists what still must be acquired.

---

## PART 1 — Studio-Owned Asset Library → Clatterhaul Integration Map

**66 owned assets reviewed. ~30 fit Clatterhaul** (already paid → zero extra cost; still verify license terms via the studio account). Fit: ★★★ Core / ★★ Strong / ★ Optional. All listed are URP-compatible unless noted. **Style caution:** packs marked ⚠ are higher-fidelity/PBR or a different stylization — run the **Style-Unification Pass** (Part 3) before shipping so everything reads as one low-poly world.

### A. Tech · Controllers · Animation
| Owned asset | Order | Clatterhaul use | Fit |
|---|---|---|---|
| **Character Controller Pro** (Lightbug) | 16-pack | Base crew locomotion (capsule, state machine, jump/dash/glide); layer physics-hands + ragdoll on top | ★★★ |
| **Traversal Pro** (physics char ctrl) | Mega T2 | Physics climb/vault/mantle/hang + IK hand/foot placement on the contraption; **pick ONE base** with CCP, harvest the other's IK/ledge | ★★ |
| **Animation Composer System (ACS)** | 22-pack | Runtime anim layering + **frame events to fire feel VFX/SFX** (doc 10) + IK; comedic overlays | ★★★ |
| **Eyes Animator** | 16-pack | Crew **googly-eye reaction faces** (panic/triumph/dizzy) + **cargo "characters"** (Reactor-Cat eyes) — doc 11/22 | ★★★ |
| **Cutscene Engine** (olivecrow) | Mega T2 | Biome vignette cards, Boss-Haul intros, finale credits, letterbox (Timeline) | ★★ |
| **Modular Multiplayer FPS Engine (Mirror)** | 16-pack | **Reference/harvest ONLY** — Mirror lobby/relay/voice/net-sync patterns (we use Mirror); do NOT import the FPS gameplay | ★★ |
| **Edy's Vehicle Physics** | 16-pack | Optional: WheelCollider feel for **wheeled locomotion modules** + Neon traffic vehicles | ★ |

### B. Feel · VFX · Shaders (game-juice, doc 10)
| Owned asset | Order | Clatterhaul use | Fit |
|---|---|---|---|
| **All In 1 Shader Nodes** | Mega T2 | **Outline (readability pillar!)**, dissolve (module break/debris), heat-distortion (Cinder), ice/glass (Glacier), water caustics (Mire), fresnel highlight on grabbables/interactables | ★★★ |
| **Lumen: Stylized Light FX 2** | Mega T2 | Stylized god-rays (Sky), neon glow (Neon), torch/fire/candle glow, lens flares, halos — time-of-day aware | ★★★ |
| **Ultimate Mesh FX** | Mega T2 | Fire-engulf (Cinder crew-on-fire gag), ice-freeze (Glacier), mesh dissolve (breaks), electric-arc (Neon rails) | ★★ |
| **Screenspace VFX** | Mega T2 | Impact hit-flash, damage vignette, screen cracks, **Disaster-Cam cinematic overlay/letterbox** | ★★ |
| **Realistic Water VFX** (Vefects) | Mega T2 | Splashes/ripples/foam/waterfall/bubbles for Mire & Glacier, rising-water Boss-Hauls, payload submersion, Fish-Tank cargo (⚠ tune to stylized) | ★★ |
| **Casual RPG VFX** | 22-pack | Bright/soft **celebration** FX: payout/unlock/rank-up bursts, collect sparkles, confetti-like juice (tone match) | ★★ |
| **VoluSmokeFX** (VFX Graph) | Mega T2 | Module-strain smoke, Cinder/Boss eruptions — use sparingly to keep stylized | ★ |
| **UNI VFX: Missiles & Explosions** (VFX Graph) | 16-pack | Rocket-puff module burst + **Fireworks-Crate cargo** gag + volcano blasts | ★ |

### C. Weather & Wind (signature mechanic — docs 13/23)
| Owned asset | Order | Clatterhaul use | Fit |
|---|---|---|---|
| **Stylized Weather System** (Unluck) | Mega T2 | **Preferred** weather — stylized rain/snow/fog matches low-poly; drives Glacier snow, Storm/Squall mutators, biome ambiance | ★★★ |
| **Zephyr: Dynamic Wind System** | Mega T2 | **Wind is core** — sails/balloons feel, Sky gusts, the Squall; plus foliage + flag-cosmetic animation; runtime API | ★★★ |

### D. Environments · Biomes · Props (docs 05/13)
| Owned asset | Order | Clatterhaul use | Fit |
|---|---|---|---|
| **POLYGON Battle Royale Pack** (Synty) | 22-pack | **Style anchor** (same Synty POLYGON language). Terrain tiles grass/desert/snow → Canyon/Glacier; loot crates → cargo; vehicle/character bases; props | ★★★ |
| **Obby Parkour Mega Pack** | Mega T1 | **Hazard scripts!** moving platforms (ping-pong/circular/elevator), checkpoint system, fall/respawn triggers, bouncy/launch pads, traps — powers haul hazards directly | ★★★ |
| **Spline Mesher Pro** (Staggart) | Mega T2 | **Winch cables, tow ropes, power lines (Neon), chain bridges (Sky), pipes, path meshes**; ideal for the "build-a-bridge" Boss-Haul | ★★★ |
| **Industrial Props Equipment Mega Bundle** ⚠ | 22-pack | **Contraption module aesthetics** (pipes/gears/tanks/scaffolding), industrial dressing, crates→cargo, hazard signage | ★★ |
| **Modular Cyber Racing Cars** | 22-pack | Contraption **wheel/panel modules** + Neon City traffic vehicles (wheel colliders ready for Edy's) | ★★ |
| **Shatter Stone Bundle** | 22-pack | **Fracture/shatter system** for module breaks + Canyon rockslide/Cinder debris; recipe/inventory patterns inform the Blueprint Garage | ★★ |
| **Toon Town** | Mega T1 | Stylized urban for **Neon Sprawl** + general toon props/vehicles/street furniture (style-matching) | ★★ |
| **Neon Interior Props** (Daelonik) ⚠ | Mega T2 | **Neon Sprawl** emissive signage/arcade/vending flavor (use selectively + re-style) | ★ |
| **Urban Abandoned District** ⚠ | 22-pack | Post-collapse world flavor (broken Canyon roads, derelict Neon) + wrecked-vehicle/debris props | ★ |
| **Stylized Dungeons** (JustCreate) | Mega T2 | **Sky-Ruins** structures + cave sections + trap/torch props (stylized) | ★ |
| **Harvest Garden** | Mega T2 | **Prize-Pumpkin / Crate-of-Eggs** cargo context + rustic Canyon/Mire dressing | ★ |
| **TerraSplines** | Mega T2 | Optional: carve Canyon ravines / Mire rivers if using Unity Terrain | ★ |
| **City Pack** ⚠ | 16-pack | Optional greybox/scale for Neon (prefer Toon Town for final style) | ★ |

### E. Characters (crew — doc 05 §2)
| Owned asset | Order | Clatterhaul use | Fit |
|---|---|---|---|
| **BoZo: Stylized Modular Characters** (chibi) | 22-pack | **Primary crew** — chibi modular (heads/bodies/armour/hair/accessories) + randomizer + humanoid rig = our cosmetic/customization system + comedic tone | ★★★ |
| **City Characters – Modular Animated** (ithappy) ⚠ | Mega T2 | Supplement: huge **80+ animation library** to retarget + crowd sim for Neon ambiance (style-check vs chibi) | ★★ |

### F. UI & Audio (docs 15/14)
| Owned asset | Order | Clatterhaul use | Fit |
|---|---|---|---|
| **Heat – Complete Modern UI** | 16-pack | **Most of doc 15**: main menu, lobby, settings + **input rebinding**, HUD shell, results/Story-Card, scoreboard/leaderboard, notifications, themes (TMP) | ★★★ |
| **Game UI & Puzzle SFX Pack** (WOW Sound) | Mega T2 | UI clicks + **payout/unlock chimes, win/fail stingers, countdown, Story-Card fanfare** (feed FMOD) | ★★★ |

### G. Tools · Workflow (dev productivity)
| Owned asset | Order | Clatterhaul use | Fit |
|---|---|---|---|
| **Asset Inventory 4** | Mega T2 | Catalog/manage **this very 66-asset library** + dependencies | ★★★ |
| **Hierarchy Designer** | 16-pack | Enforce the **scene-hierarchy standard** (doc 05 §5) + productivity (color/icons/separators) | ★★★ |
| **Colorize** (palette modifier) | 22-pack | **60+ cosmetic paints** + biome palette variants + module color variants **without duplicating textures**; team-color system | ★★★ |
| **LightMap Fusion Pro** | Mega T2 | **Night mutator** + biome day/night lightmap switching without re-bake (doc 05 §7) | ★★ |

---

## PART 2 — External packages still required (NOT in the owned library)
The owned library covers art, UI, weather, many VFX, and tools — but the **core tech stack** must still be acquired:

| Package | Tier | Cost | Why owned library doesn't cover it |
|---|---|---|---|
| **Mirror** + **FizzySteamworks** + **Steamworks.NET** | Core | Free | Our host-authoritative netcode/Steam P2P (MMFPSE only *references* Mirror) |
| **PuppetMaster (RootMotion)** | Core | Paid | **Active-ragdoll** physics-hands/bodies (owned controllers are kinematic, not ragdoll) |
| **FMOD for Unity** | Core | Free (rev) | Adaptive-music/strain **audio engine** (WOW Sound provides SFX *content*, not the engine) + source biome music |
| **DOTween (Pro)** | Core | Paid/Free | Juice/UI tweening |
| **Easy Save 3** | Core | Paid | Save schema v2 + Steam Cloud |
| **Clip recorder** (NatCorder/AVPro-style) | Recommended | Paid | In-game MP4/GIF export (virality, doc 11) |
| **Synty POLYGON biome kits** (Nature/Snow/Western-Desert/Sci-Fi City/Fantasy) | Recommended | Paid | Owned POLYGON BR covers grass/desert/snow + props; **Mire, Cinder, Sky, full Neon** need more kits |
| **Cinemachine 3** | Core | Free (UPM) | Smart cam + Disaster-Cam (already in manifest) |

---

## PART 3 — Style-Unification Pass (mandatory before shipping mixed-source art)
Clatterhaul's look = **stylized low-poly Synty POLYGON**. Owned packs marked ⚠ (Industrial Props, Neon Interior Props, Urban Abandoned, City Pack, City Characters) are higher-fidelity/different stylization. The **Technical Artist** runs a unification pass on any ⚠ asset before approval (QA gate, doc 06):
1. Swap materials to flat/stylized URP mats; apply **All-In-1 outline** node for the POLYGON read.
2. Unify palette with **Colorize** to the biome's swatches (doc 13).
3. Reduce/decimate over-detailed meshes, or use only as **silhouette / background LOD / greybox**.
4. Re-check texel density, lightmap UVs, grounding, pivots (doc 05 §5).
**Style anchors** (final look): BoZo (crew) + POLYGON BR + Toon Town (environments). Treat realistic packs as supplementary, re-styled.

---

## PART 4 — Owned assets NOT used (and why)
| Asset(s) | Reason |
|---|---|
| MFPS 2.0, Horror Multiplayer Template | **Photon** networking (we use Mirror) + FPS/horror genre mismatch (MMFPSE used as the Mirror reference) |
| Realistic Blood VFX, Volumetric Blood Fluids | Clatterhaul is **non-violent comedy** (no gore) |
| Anime Powers Pack, Stylized VFX Bundle*, Spells Pack, 100 Special Skills, Magic Arsenal | Combat/magic VFX & weapons — **no magic/combat** (*also Built-in-only / 2023.1+) |
| Medieval Village Megapack, The Medieval Castle, Fantasy Castle Environment | Wrong setting (no medieval/fantasy biome) |
| Office Floors, Sci-Fi Low Poly Interior Bundle, Sci-Fi Space Stations Creator | No office/sci-fi-interior/space biome |
| Stylized Fantasy Creatures #2, Fantasy Monsters Bundle | Our nuisance fauna are **mundane** (goats/penguins/gators/pigeons), not fantasy monsters |
| Animated 2D Characters Monsters | 3D game |
| Bamao Fantasy GUI | Fantasy tone — **Heat** is our UI |
| UniStorm, Weather Maker | Realistic/heavy — **Stylized Weather** preferred (style + Deck perf) |
| Microdetail Terrain System | Modular-kit world; minimal Unity Terrain reliance |
| UniPay (IAP) | Premium one-time PC game; cosmetic DLC is direct-purchase, not IAP |
| Dialogue System OpenAI Addon | Authored short barks; no dynamic AI dialogue (and needs unowned Dialogue System) |
| Perks for Game Creator 2 | Requires Game Creator 2 (not used) |
| Skill Tree / Talent Tree Builder | No talent tree (progression = ranks/cosmetics/sidegrade modules) |
| Complete Racing Game 2 | Racing template, not our genre |

---

## Integration rules (conflict-free)
1. One high-level netcode (**Mirror**) — never NGO/Photon alongside (so MMFPSE is reference-only; do not import its Photon-free FPS wholesale into our scenes).
2. Isolate every pack under `Assets/ThirdParty/<Vendor>/`; never overwrite URP asset / Input actions / Tags & Layers.
3. Pin & record versions here; re-run EditMode tests after each import; mind **min Unity versions** (several owned tools need 2022.3+ — we're on 6000.4.4f1, fine).
4. Strip demo scenes/scripts/cameras/audio-listeners before shipping.
5. No committed secrets (Steam App ID); secret-scan each phase.
6. License ledger here; verify **runtime capture/recording** license specifically.
7. Every ⚠ asset passes the **Style-Unification Pass** before the environment-review gate.

## Budget thesis (updated)
The **owned 66-asset library (paid $184.72, ~$4,000 retail)** already covers most art, UI, weather, VFX, and tooling. Remaining external spend is small and focused (PuppetMaster, Easy Save 3, DOTween, a recorder, extra Synty kits) plus free stacks (Mirror, FMOD tier, Cinemachine). **Buy the few missing tools; reuse the owned library; build the systems.**

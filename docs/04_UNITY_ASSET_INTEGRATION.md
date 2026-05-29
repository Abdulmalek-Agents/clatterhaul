# Clatterhaul — Unity Asset Store & Package Integration Plan

**Version:** 1.0 (Phase 2)  ·  **Owner:** Unity Asset Store Integration Experts + Package/Dependency Experts

> Every third-party package is evaluated for **license compatibility (commercial Steam release), performance cost, and conflict-free integration** before adoption, per studio rule. Verify current license terms at purchase time.

## Legend
- **Tier:** Core (must-have) / Recommended / Optional
- **Cost:** Free / Paid (one-time Asset Store)
- **License note:** standard Unity Asset Store EULA permits use in a shipped commercial game unless stated; confirm per-asset.

## Networking & online
| Package | Tier | Cost | Purpose | Notes / conflicts |
|---|---|---|---|---|
| **Mirror** | Core | Free (OpenUPM/Store) | High-level netcode | No CCU fees; host-authoritative. Choose ONE high-level lib (no NGO alongside). |
| **FizzySteamworks** | Core | Free | Steam P2P transport for Mirror | Pair with Steamworks.NET; set transport on NetworkManager. |
| **Steamworks.NET** | Core | Free | Steam lobbies/invites/voice | Requires `steam_appid.txt`; do not commit real App ID. |
| **Dissonance Voice Chat** | Recommended | Paid | Robust proximity VOIP | Has Mirror integration package; alt = Steam voice (free) if budget-tight. |

## Physics, animation & feel
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **PuppetMaster (RootMotion)** | Recommended | Paid | Active-ragdoll for players + physics-hands feel | Industry standard for Human-Fall-Flat-style bodies; profile on Deck. |
| **Obi Rope** | Optional | Paid | Winch cables / tow ropes as real rope physics | Adds CPU cost; cap rope count; or fake with `ConfigurableJoint` if perf-bound. |
| **DOTween Pro** | Recommended | Paid | UI/camera tweening, disaster-cam slow-mo | Lightweight; avoid in hot physics loops. |

## Art & environment (the bulk of paid spend)
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **Synty POLYGON** biome packs (Nature, Snow, Western/Desert, Sci-Fi City, Fantasy) | Core | Paid | Stylized modular kits for the 6 biomes — fastest path to a cohesive look | Single art language across biomes = cheap + cohesive; superb perf (low-poly, atlased). Check lightmap UVs; some props need pivot/grounding fixes (QA-Art pass). |
| **Synty POLYGON Particle/FX** | Recommended | Paid | Stylized dust/impact/break VFX | Matches POLYGON look; URP variants. |
| **Skybox / Time-of-day** (e.g. stylized skies) | Optional | Paid | Biome mood | Bake reflection probes per biome. |

## Audio
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **FMOD for Unity** | Recommended | Free (lic. by revenue) | Adaptive strain/impact audio | Free under FMOD indie revenue threshold; confirm tier. |
| **Stylized SFX pack** (impacts/creaks) | Recommended | Paid | Contraption strain library | Drives the "readable physics" audio telegraph. |

## Tools & save
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **Easy Save 3** | Recommended | Paid | Robust local save (unlocks/cosmetics/settings) | Avoids hand-rolled JSON edge cases. |
| **Hot Reload** | Optional | Paid | Faster iteration | Editor-only; not shipped. |

## Integration rules (conflict-free)
1. **One high-level netcode library only** (Mirror). Never import NGO/Photon high-level alongside.
2. Import each paid pack into an isolated folder; never let a pack overwrite project settings (URP asset, Input actions, Tags/Layers) — reconcile manually.
3. Pin versions; record exact versions in this doc on adoption. Re-run EditMode tests after each import.
4. Keep all third-party under `Assets/ThirdParty/<Vendor>/` and exclude from our asmdefs except via explicit references.
5. Strip demo scenes/scripts from shipped build to control size and avoid stray cameras/audio listeners.
6. License ledger maintained here; no GPL/again-incompatible assets in the shipped client.

## Estimated paid-asset budget
Low hundreds of USD in one-time Asset Store purchases (Synty packs dominate). This is the core cost-saving thesis: **buy the art language, build the systems.**

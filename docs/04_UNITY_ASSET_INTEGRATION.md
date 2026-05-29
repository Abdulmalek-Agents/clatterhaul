# Clatterhaul — Unity Asset Store & Package Integration Plan

**Version:** 2.0 (post-review)  ·  **Owner:** Asset Store Integration + Package/Dependency Experts

> Every package evaluated for **license compatibility (commercial Steam release), performance cost, and conflict-free integration**. v2.0 adds packages for the new feel/humor/clip/live-ops systems. Confirm current terms at purchase; pin & record versions on adoption.

## Networking & online
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **Mirror** | Core | Free | high-level netcode (host-authoritative) | one high-level lib only |
| **FizzySteamworks** | Core | Free | Steam P2P transport | pair with Steamworks.NET |
| **Steamworks.NET** | Core | Free | lobbies/invites/voice/**Workshop**/leaderboards/cloud | `steam_appid.txt`; never commit real App ID |
| **Dissonance Voice Chat** | Recommended | Paid | robust proximity VOIP (Mirror integration) | alt = Steam voice (free) |

## Feel, animation & comedy
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **PuppetMaster (RootMotion)** | Core | Paid | active ragdoll + physics-hands + comedic catches | profile on Deck |
| **DOTween Pro** | Core | Paid | juice tweens, Disaster-Cam, UI | keep out of hot physics loops |
| **Cinemachine 3** | Core | Free (UPM) | smart cam + Disaster-Cam rigs | included |
| **Animation pack(s)** (emotes, celebrate/fail, idles) | Recommended | Paid | expressive comedy anims | retarget to active ragdoll |
| **Obi Rope** | Optional | Paid | real winch/tow rope physics | cap rope count or fake w/ joints |

## Clip / capture (virality)
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **NatCorder / AVPro-style recorder** | Recommended | Paid | in-game MP4/GIF clip export | off-thread encode; Deck perf budget; verify license for shipped runtime capture |
| Unity Recorder | Dev only | Free | editor capture for marketing | not shipped |

## Art & environment (bulk of paid spend)
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **Synty POLYGON** biome kits (Nature, Snow, Western/Desert, Sci-Fi City, Fantasy, Apocalypse) | Core | Paid | 6 biomes + Depot hub, one cohesive art language | check lightmap UVs/pivots on import |
| **Synty POLYGON Particles/FX** | Recommended | Paid | stylized dust/spark/break/confetti | URP variants |
| **Stylized skies / time-of-day** | Optional | Paid | biome mood | bake reflection probes |

## Audio
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **FMOD for Unity** | Core | Free (rev-based) | adaptive music + strain/feel events | confirm indie tier |
| **Music + SFX packs** (folk/orchestral per biome, impacts/creaks) | Recommended | Paid | biome identity + strain library | per-biome banks |

## Tools & save
| Package | Tier | Cost | Purpose | Notes |
|---|---|---|---|---|
| **Easy Save 3** | Core | Paid | save schema v2 + Steam Cloud | robust |
| **Hot Reload** | Optional | Paid | iteration | editor-only |
| **Odin Inspector** | Optional | Paid | SO/data tooling for designers | editor-only |

## Integration rules (conflict-free)
1. One high-level netcode (Mirror) — never NGO/Photon alongside.
2. Isolate packs under `Assets/ThirdParty/<Vendor>/`; never overwrite URP asset / Input actions / Tags & Layers.
3. Pin & record versions here; re-run EditMode tests after each import.
4. Strip demo scenes/scripts/cameras/audio-listeners before shipping.
5. No committed secrets (App IDs); secret-scan each phase.
6. License ledger here; verify **runtime capture/recording** license specifically (shipped clip export).

## Budget thesis
Low hundreds of USD one-time (Synty + a few paid tools). **Buy the art language + feel tools; build the systems.** This is the cost-saver enabling a 99%-aiming co-op hit on a small budget.

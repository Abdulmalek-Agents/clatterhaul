# Clatterhaul

> **Build a terrible machine. Haul it home. Try not to die laughing.**

A **2–4 player co-op physics-contraption traversal comedy** for PC (Steam).

| | |
|---|---|
| **Engine** | Unity **6000.4.4f1** / URP |
| **Networking** | **Mirror** + FizzySteamworks (Steam P2P, host-authoritative) |
| **Players** | 2–4 co-op |
| **Target playtime** | **~10h+** |
| **Platform** | Windows 64-bit (Steam), Steam Deck verified |
| **Docs** | **v3.0 — final, development-ready** |

## 📘 Start here
→ **[`docs/00_PRODUCTION_BIBLE.md`](docs/00_PRODUCTION_BIBLE.md)** — the single entry point: quick-start, documentation map by discipline, milestone→doc roadmap, and the ~10-hour content overview.

The documentation set has been trimmed to the **final development-ready docs only** and organized by track:

- **Design:** GDD (01), Narrative (07), Level/Biomes (13)
- **Content (the 10h):** Pacing (09), **Content Manifest (20)**, First-90 (25), Modules (21), Cargo (22), Mutators (23), Economy (12), Balance (26), Barks (24)
- **Feel & Fun:** Feel/Juice (10), Humor (11), Audio (14)
- **Tech:** Technical Design (02), Implementation (03), Asset Integration (04)
- **Art / UX / QA / Roadmap:** Art/Env (05), UX/Onboarding (15), Accessibility (16), QA (06), Test Cases (27), Live-ops (17)
- **Arabic:** [`docs/AR/`](docs/AR/)

## Project layout
```
Assets/_Project/Scripts/   Clatterhaul.Runtime (Core, no Mirror) + Clatterhaul.Net (Mirror)
Assets/Tests/              EditMode/PlayMode tests
Packages/manifest.json     URP 17, Cinemachine 3, Input System, Test Framework
ProjectSettings/           Unity 6000.4.4f1
docs/                      the production bible (start at 00)
```

## Workflow
Branch-per-phase → PR → QA (+ Art/Environment for scenes) sign-off → merge. See `docs/00_PRODUCTION_BIBLE.md` §8.

---
_© Abdulmalek-Agents. Internal concept project._

# Clatterhaul

> **Build a terrible machine. Haul it home. Try not to die laughing.**

A **2–4 player co-op physics-contraption traversal comedy** for PC (Steam).
Lineage: *PEAK* × *RV There Yet?* × *Human Fall Flat* × *Lethal Company*'s panic-comedy energy.

| | |
|---|---|
| **Engine** | Unity **6000.4.4f1** |
| **Render Pipeline** | URP (Universal Render Pipeline) |
| **Networking** | **Mirror** + FizzySteamworks (Steam P2P, friend-hosted) |
| **Players** | 2–4 co-op (host-authoritative) |
| **Target playtime** | ~10 hours (6 biome haul-runs + modifier deck + cosmetics) |
| **Platform** | Windows 64-bit (Steam), Steam Deck verified target |
| **Price point** | $9.99–$12.99 (impulse, group-buy friendly) |

---

## The pitch

A crew shares control of one absurd, modular contraption — legs, wheels, a balloon, a crane-arm, a sail — and a fragile, precious payload. Together you haul it across escalating hazard courses, winching, balancing, and improvising when (not *if*) it breaks. **Proximity voice chat** turns every catastrophic collapse into a story you retell for weeks.

## Why this game (validated)

Co-op generated ~$4.1B on Steam in H1 2025 and "play with friends" is the most reliable predictor of viral success. The biggest budget hits (PEAK, R.E.P.O.) are physics-chaos + proximity-chat machines. Clatterhaul is engineered for exactly that clip-able, group-buy, >90%-positive flywheel. Full evidence: [`docs/00_PORTFOLIO_5_IDEAS_AND_VALIDATION.md`](docs/00_PORTFOLIO_5_IDEAS_AND_VALIDATION.md).

## Documentation

| Doc | Purpose |
|---|---|
| [`docs/00_PORTFOLIO_5_IDEAS_AND_VALIDATION.md`](docs/00_PORTFOLIO_5_IDEAS_AND_VALIDATION.md) | The 5-concept slate + market validation |
| [`docs/01_GAME_DESIGN_DOCUMENT.md`](docs/01_GAME_DESIGN_DOCUMENT.md) | Full GDD |
| [`docs/02_TECHNICAL_DESIGN_DOCUMENT.md`](docs/02_TECHNICAL_DESIGN_DOCUMENT.md) | Architecture & networking (Phase 2) |
| [`docs/03_IMPLEMENTATION_GUIDELINES.md`](docs/03_IMPLEMENTATION_GUIDELINES.md) | Phase-by-phase build plan (Phase 2) |
| [`docs/04_UNITY_ASSET_INTEGRATION.md`](docs/04_UNITY_ASSET_INTEGRATION.md) | Asset Store integration plan (Phase 2) |
| [`docs/05_ART_AND_ENVIRONMENT_PLAN.md`](docs/05_ART_AND_ENVIRONMENT_PLAN.md) | Art direction & environment standards (Phase 2) |
| [`docs/06_QA_TEST_PLAN.md`](docs/06_QA_TEST_PLAN.md) | QA & environment-review gates (Phase 2) |
| [`docs/07_NARRATIVE_AND_WORLD.md`](docs/07_NARRATIVE_AND_WORLD.md) | World, tone & writing bible |
| [`STUDIO_LOG.md`](STUDIO_LOG.md) | Living phase/decision log |

## Branch & phase workflow

Development is pushed in **QA-gated phases** on feature branches → PR → merge after QA + Art/Environment sign-off.

- `phase-1-foundation` — skeleton + design/narrative docs
- `phase-2-tech-and-assets` — technical design, implementation guide, asset plan, code stubs, tests

---
_© Abdulmalek-Agents. Internal concept project._

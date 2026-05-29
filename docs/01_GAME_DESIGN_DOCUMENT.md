# Clatterhaul — Game Design Document (GDD)

**Version:** 1.0 (Phase 1)  ·  **Owner:** Game Design team  ·  **Engine:** Unity 6000.4.4f1 / URP  ·  **Net:** Mirror + Steam P2P

---

## 1. Vision statement

Clatterhaul is the game your friend group keeps coming back to on a Friday night. Four players share one ridiculous, breakable machine and a payload they must *not* drop, and haul it across a hostile world. The fun is not in *winning cleanly* — it's in the gloriously stupid ways you almost don't. Every run is a story; every clip is an ad.

## 2. Design pillars

1. **Shared piloting, shared blame.** No single player controls the contraption. Success requires constant, loud coordination — the source of all comedy and all triumph.
2. **Readable physics, unpredictable outcomes.** Players must always *understand* why something happened (so they can do better) while never being able to fully *predict* it (so it stays funny).
3. **Forgive the player, punish the machine.** Players ragdoll, dust off, and laugh. The contraption takes the damage. Failure is a setback, never a humiliation.
4. **Every session is a highlight reel.** Proximity voice, expressive ragdolls, and slow-motion disaster cams make moments inherently shareable.
5. **Drop-in, drop-out, drop-everything.** Onboarding is < 60 seconds. A friend can join mid-haul.

## 3. Target audience & market fit

- **Primary:** 18–34 friend groups of 2–4 who buy cheap co-op games together and play on Discord. Overlaps directly with PEAK, R.E.P.O., Lethal Company, Content Warning, Human Fall Flat audiences.
- **Secondary:** Streamers/creators seeking high-clip-density gameplay.
- **Fit:** Sub-$13 impulse price, group-buy friendly, Steam Remote Play / proximity-chat native, Steam Deck verified.

## 4. Core gameplay loop

```
PREP (in hub)  →  DEPART  →  HAUL LEG 1  →  HAZARD/EVENT  →  HAUL LEG 2  → ... →  EXTRACTION  →  PAYOUT/UNLOCKS  →  (back to PREP)
```

1. **Prep:** In the hub, the crew assembles/repairs the contraption from unlocked modules and loads the payload.
2. **Haul:** Players man stations (steer, pedal, crank the crane, trim the sail) and/or use physics-hands to brace cargo, push, or pull.
3. **Hazards & events:** Terrain breaks, weather hits, modifiers fire. The machine *will* fail in ways that require improvisation.
4. **Extraction:** Reach the goal with as much payload value intact as possible.
5. **Payout:** Value → currency → cosmetic + module unlocks. No power creep that breaks balance (see §8).

## 5. The contraption (signature system)

The contraption is a **physics body composed of modular parts** connected by configurable joints.

### 5.1 Module categories
| Category | Examples | Role |
|---|---|---|
| **Chassis** | flatbed, cradle, cage | The payload mount; defines weight & balance |
| **Locomotion** | wheels, mechanical legs, tank-tracks, paddle-wheel | How it moves; each handles terrain differently |
| **Lift/Assist** | balloon, sail, crane-arm, winch, spring-jack | Vertical help, towing, recovery |
| **Stabilizers** | outriggers, gyro, ballast | Anti-tip; trades speed for safety |
| **Cosmetic** | paint, horns, flags, hats | No gameplay effect (monetization-safe) |

### 5.2 Stations & physics-hands
- **Stations** are interaction points (steering yoke, pedal, crane lever, sail rope). One player per station; control is networked and hand-off-able.
- **Physics-hands**: any player not on a station has Human-Fall-Flat-style grab hands to brace cargo, hold a snapping rope, or shove the machine off a ledge.
- **The tension:** there are always more useful jobs than hands. Crews must triage in real time.

### 5.3 Payload
- A fragile, high-value object (the "Cargo") with a **condition meter**. Impacts, tipping, and submersion chip it. Final payout scales with surviving condition → creates the core "protect the precious thing" drama.

## 6. Hazard & event design

- **Static terrain hazards:** ravines (need winch/crane), mud (bogs wheels), ice (low friction), narrow ledges, collapsing bridges.
- **Dynamic events:** wind gusts (vs balloon/sail), rockslides, rising water, fauna nuisances (non-lethal animals that nudge the machine — echoing the wildlife-pressure that made RV There Yet? funny).
- **Design rule:** every hazard has at least **two valid co-op solutions** to reward creativity, never memorization.

## 7. Content & depth to ~10 hours

| Source of depth | Detail | Est. hours |
|---|---|---|
| **6 biomes** | Canyon, Swamp, Glacier, Volcano, Neon City, Sky-Ruins — each with unique terrain physics | ~5.0 |
| **Branching routes** | 2–3 route forks per biome (safe/slow vs risky/fast) | +1.5 |
| **Modifier deck** | Daily-rotating run modifiers (low-grav, greased joints, storm, fragile cargo, night) | +1.5 |
| **Mastery & cosmetics** | "Perfect haul" leaderboard goals, contraption cosmetics, achievements | +2.0 |
| **Total** | | **~10h** |

Replayability (not raw length) is the retention engine — consistent with the friend-slop model.

## 8. Progression & economy

- **Currency:** "Scrip" earned from payload value + run bonuses.
- **Unlocks:** new modules (sidegrades, not strict upgrades), biomes, cosmetics, modifier cards.
- **Anti-power-creep rule:** modules are **sidegrades** (trade-offs) so veterans and newcomers can always play together fairly — protects the group-buy social loop and review score.

## 9. Multiplayer design

- **Model:** Host-authoritative (the host simulates physics; clients send input + interpolate). 2–4 players, friends-first via Steam lobbies.
- **Why host-authoritative:** physics determinism across clients is impractical; one authority avoids desync of the joint-heavy contraption.
- **Join flow:** Steam invite → lobby → ready → depart. Drop-in allowed in hub; late-join in-run spectates until next safe checkpoint.
- **Proximity voice:** distance-attenuated VOIP is a first-class feature, not an afterthought (it is the comedy delivery system).
- Full architecture: see `docs/02_TECHNICAL_DESIGN_DOCUMENT.md`.

## 10. Camera, controls, UX

- **Camera:** Cinemachine 3 third-person with smart framing that keeps the contraption + nearby players in view; auto "disaster cam" slow-mo on catastrophic tip/break for clip value.
- **Controls:** Unity Input System; full gamepad + KB/M; context-sensitive interact; one-button grab.
- **UX:** minimal HUD (payload condition, distance-to-goal, ping wheel, voice indicators). Onboarding via a 60-second "first hill" tutorial.

## 11. Audio & game feel

- Creaks, groans, and metal stress sounds scale with joint strain (telegraphs imminent failure — readable physics pillar).
- Triumphant stinger on extraction; comedic stinger on total wipeout.
- Haptics on gamepad for strain/impact.

## 12. Accessibility

- Colorblind-safe hazard markers, subtitle/caption support for VO and key SFX, remappable controls, voice-to-text optional, adjustable physics-assist ("sticky grab") toggle.

## 13. Monetization & pricing

- **Premium one-time purchase $9.99–$12.99.** No pay-to-win. Optional post-launch cosmetic DLC packs. Friend-pass consideration (one purchase, invite a friend for a trial leg) modeled on Split Fiction's goodwill.

## 14. MVP / vertical slice scope

The Phase 2–3 vertical slice ships **1 biome (Canyon), 5–6 modules, 1 payload, 3 hazards, 2–4p networked play, proximity voice, full prep→haul→extract loop.** Everything else scales from these systems.

## 15. Success metrics (target)

- **≥95% positive** Steam reviews at launch (target 99% band).
- **Median session ≥ 35 min**, ≥ 3 sessions/week for active groups.
- **Wishlist → sale** conversion fueled by a Next Fest demo with a single, perfectly clip-able hazard.

## 16. References / comps

PEAK, RV There Yet?, Human Fall Flat, Lethal Company, Content Warning, Tools Up!, Snowrunner (terrain-traversal feel).

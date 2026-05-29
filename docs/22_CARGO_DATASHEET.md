# Clatterhaul — Cargo Datasheet (all 12)

**Version:** 3.0  ·  **Owner:** Systems + Comedy Writers  ·  Resolves C2-R1-CARGO-3, C2-R2-CARGOREACT-2

> Cargo is the heart of the tension *and* a comedy character. **Cond** = condition HP (abstract 0–100; payout scales with surviving %). **Frag** = damage multiplier (higher = chips faster). Reactions fire via feel events (doc 10) and audio (doc 14). Payload **chips, never instantly shatters** (R3-FRUST-2).

| Cargo | Cond | Frag | Main damage | Reactions (safe / bump / hard-hit / near-miss) | Quirk | Biomes | Payout tier |
|---|---|---|---|---|---|---|---|
| **Giant Cheese Wheel** | 120 | 0.8 | rolling off, impacts | hums / wobble / squish-dent / — | rolls free if unsecured (chaos) | Canyon | low |
| **Crate of Eggs** | 70 | 1.4 | any jolt | rattle / crack-sfx / yolk-splat (lose %) / — | every bump risks a crack | all | mid |
| **Sleeping Reactor-Cat** | 100 | 1.0 | hard hits, water | purr / ear-twitch / **YOWL** + crew flinch / blink | purrs when calm = audio safety meter | Glacier/Cinder | mid |
| **Ice Sculpture** | 110 | 0.9 | heat (melts over time!) | gleam / drip / chunk-off / sweat | built-in melt clock in Cinder | Cinder/Glacier | high |
| **Mayor's Chandelier** | 60 | 1.6 | tilt, impacts | ting / loud-ting / crystal-shatter (lose %) / sway | vain & fragile; tings telegraph danger | Mire/Neon | high |
| **Live Fish Tank** | 80 | 1.2 | sloshing, tipping | bubbles / slosh / spill (lose %) / fish-stare | fish reacts to your driving | Mire/Neon | mid |
| **Founder's Statue** | 140 | 1.1 | impacts, falls | stoic / dust / chip / — | finale cargo; heavy & proud | Sky/Neon | top |
| **Grandfather Clock** | 75 | 1.3 | tilt, jolts | tick-tock / off-beat / bong+gears / chime | chimes on the hour (random gag) | Canyon/Neon | mid |
| **Beehive** | 90 | 1.1 | hard hits | hum / buzz-up / **swarm** (crew panic) / settle | hard hits release nuisance bees | Mire/Canyon | mid |
| **Fireworks Crate** | 65 | 1.5 | heat, impacts | fizz / spark / **pop-launch** (lose % + spectacle) / hiss | heat/impact = comedic mini-blast | Cinder/Neon | high |
| **Potion Vat** | 85 | 1.2 | tilt, submersion | glow / bubble / overflow (lose %) / fizz | sloshes; color-changes by tilt | Mire/Sky | mid |
| **Prize Pumpkin** | 130 | 0.7 | impacts | — / squeak / squish-dent / — | huge, soft, bouncy (comedy physics) | Canyon/Mire | low |

## Reaction → system hooks
- **Audio-as-meter:** Reactor-Cat purr (safe) → yowl (danger) doubles as a hands-free condition cue (accessibility win, doc 16).
- **Telegraph gags:** Chandelier ting & Clock tick rise with instability — comedic *and* readable (doc 11).
- **Spectacle damage:** Fireworks/Beehive turn payload loss into a shareable Disaster-Cam beat (doc 10).

## Authoring DoD (with QA, doc 27)
- [ ] Cond/Frag wired to payout (26); reactions bound to feel events (10) + FMOD (14).
- [ ] Each cargo has 4 reaction states + 1 quirk; loss is gradual & legible.
- [ ] At least one cargo-driven comedy beat per assigned biome.

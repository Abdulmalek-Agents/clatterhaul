# Clatterhaul — Game Feel & Juice Spec

**Version:** 2.0  ·  **Owner:** Physics/Gameplay Programmers + Technical Artist + Animation  ·  Source of R1-FEEL-4 / R2-FEEL-3 / R2-CLIP-4 resolution

> In a physics-comedy, **feel is the product.** Every interaction must be tactile, legible, and delicious. This spec defines the feedback layers so the toy feels incredible before any content is added.

## 1. The feedback stack (apply to every meaningful event)
Impact / success / failure events fire a **layered response**: `Hit-stop → Screen-shake → Squash/Stretch → VFX → SFX → Haptics → (optional) Disaster-Cam`. Each layer is data-driven (ScriptableObject "FeelProfile") so designers tune without code.

## 2. Impact & hit-stop
| Event | Hit-stop | Shake (amp/dur) | Notes |
|---|---|---|---|
| Light bump | 0 ms | 0.05 / 0.08s | subtle |
| Hard impact | 40–80 ms | 0.2 / 0.18s | scales with relative velocity |
| Module break | 90 ms | 0.35 / 0.25s | + debris + slow-mo trigger if severe |
| Payload chip | 60 ms | 0.25 / 0.2s | + cargo reaction (doc 11) |
| Boss-Haul clear | 120 ms | celebratory zoom | triumphant stinger |

Hit-stop is **global time-scale dip** (host-authoritative, replicated) capped so networking stays sane; clients apply local visual freeze only when safe.

## 3. Camera (Cinemachine 3)
- **Default:** smart third-person framing keeping contraption + nearest players in shot; dynamic FOV widens with speed.
- **Disaster Cam (signature):** on catastrophic tip/break/fall, auto slow-mo (0.35x) + orbit hero-shot for ~1.2s, then snap back. Auto-bookmarks the moment for Replay/clip export (doc 11, 15).
- **Anti-nausea:** all shake/slow-mo respect accessibility toggles (doc 16); shake uses smoothed Perlin, not jitter.

## 4. Squash, stretch & active ragdoll
- Contraption modules use subtle squash/stretch on load/impact (TA shader + scale anim) for cartoon weight.
- Players are **active ragdolls** (PuppetMaster, doc 04): keep posture when controlled, flail/ragdoll on big hits, auto-recover after settle. Catches (grabbing a falling teammate) snap with a satisfying spring.

## 5. Grab feel (core verb)
- One-button grab: short reach SphereCast → spring joint with tuned `positionSpring/Damper` for that elastic Human-Fall-Flat pull.
- **Feedback:** snap SFX + small hand squash + rumble pulse on successful grab; strain creak while holding heavy/ snapping loads.
- Sticky-grab assist (doc 16) raises hold tolerance for accessibility without changing the core feel.

## 6. Winch & tension (the most satisfying tool)
- Winch cable uses a **tension curve**: visual rope sag → taut → quiver near limit; audio pitch rises with tension; rumble intensifies; a "ping" warns before snap. Reeling in has rhythmic clicks. This turns a utility into a feel highlight.

## 7. Strain telegraph (3-stage — ties to readability pillar)
1. **Creak** (subtle audio + tiny wobble) — "careful."
2. **Groan + stress decals** (sparks at joints, slight smoke) — "it's going."
3. **Snap** (break + debris + Disaster-Cam) — the payoff.
Players can always read how close to failure they are (so improvement feels fair) while exact timing stays funny.

## 8. VFX language (Synty/URP particles — doc 04)
Dust puffs (movement/landings), sparks (metal strain/scrapes), debris chunks (breaks, pooled), splashes (water), heat shimmer (volcano), snow spray (glacier), confetti (Boss-Haul clear). Consistent stylized look; all pooled to a body/particle budget (doc 02).

## 9. Audio hooks
Every feel event maps to an FMOD event (doc 14): impact bonks, creak/groan/snap stems, winch tension, cargo reactions, triumph/wipeout stingers. Audio carries 50% of comedic timing.

## 10. Haptics
Gamepad rumble profiles per event (grab pulse, strain rumble ramp, impact thump, Boss-clear cheer). Respect off-toggle.

## 11. The Feel Checklist (QA gate, doc 06)
- [ ] Does every impact have stop+shake+squash+VFX+SFX+rumble?
- [ ] Can a new player read "how close to breaking" in <1s?
- [ ] Is the winch satisfying enough to use for fun?
- [ ] Does a disaster auto-produce a clip-worthy slow-mo?
- [ ] Do assists preserve feel while reducing difficulty?
- [ ] Steam Deck: feel layers stay within frame budget (no hitches)?

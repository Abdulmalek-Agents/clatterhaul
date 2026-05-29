# Clatterhaul — Audio & Music Design

**Version:** 2.0  ·  **Owner:** Audio Director + Sound Designers  ·  Source of R2-AUD-9 resolution

> Audio carries ~50% of Clatterhaul's comedic timing and almost all of its tension telegraph. It is a gameplay system, not decoration. Implemented in **FMOD for Unity** (doc 04).

## 1. Audio pillars
1. **Readable strain** — the player hears how close the rig is to failure (doc 10 §7).
2. **Comedic timing** — stingers and reactions land the joke.
3. **Proximity intimacy** — positional voice is the social/comedy core.
4. **Biome identity** — each Reach has a musical and ambient signature.
5. **Mix clarity** — voice and danger cues always cut through chaos.

## 2. Adaptive music
- Per-biome **stem-based** tracks (FMOD parameter-driven): `exploration` → `tension` (near hazard/strain) → `calamity` (set-piece) → `triumph/fail` stinger.
- Intensity parameter driven by collapse/strain, proximity to Boss-Haul, and payload condition.
- **Boss-Haul** gets a bespoke 3-stage track that climaxes on extraction.
- Style: playful orchestral-folk per biome (banjo Canyon, glassy bells Glacier, brass Neon, etc.) — warm, never grim.

## 3. The strain-audio system (comedy timing engine)
- 3 layered stems per stressed joint/module: **creak → groan → snap**, blended by tension value.
- Winch tension: pitch + click-rate rise to a pre-snap "ping."
- Cargo reactions are first-class audio (Reactor-Cat purr/yowl, Chandelier ting, Fish slosh) and double as gameplay feedback.

## 4. SFX categories
Impacts/bonks (velocity-scaled), scrapes/sparks, debris, splashes, mud squelch, ice crackle, lava roar, traffic/city, wind/gusts, fauna, UI clicks, emote SFX, triumph/wipeout stingers. All pooled & velocity/material-aware.

## 5. Proximity voice (the social core)
- Distance-attenuated VOIP (Dissonance or Steam voice — doc 04), with occlusion-light falloff so far teammates sound far (miscommunication = comedy).
- Push-to-talk + open-mic options; per-player volume; mute; captions (doc 16).
- "Megaphone" cosmetic gag item (temporary range boost) for streams.

## 6. Mix bus structure
`Master → [Music, SFX, Voice, UI, Stingers]`. Voice and "danger" SFX ducked-priority over music; loudness-normalized; per-bus sliders in options. Target broadcast-safe loudness for streamers.

## 7. FMOD implementation plan
- FMOD events per feel-event (doc 10) referenced by `FeelProfile` SOs.
- Banks split by biome for streaming; ambience as looping multi-instruments.
- Music callbacks for beat-synced stingers where feasible.

## 8. Accessibility audio (doc 16)
Subtitles/captions for VO + key SFX (with direction indicators), mono toggle, separate sliders, visual strain indicator mirror for hard-of-hearing, reduce-loud-sounds option.

## 9. Audio QA (doc 06)
Verify strain audibility over chaos, voice clarity at distance, no clipping/limiter pumping, stinger timing lands the joke, Deck performance (streamed banks, voice CPU budget).

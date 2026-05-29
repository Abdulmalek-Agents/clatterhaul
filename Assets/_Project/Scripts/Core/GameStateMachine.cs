using System;

namespace Clatterhaul.Core
{
    /// <summary>Top-level game states.</summary>
    public enum GameState { Boot, MainMenu, Lobby, Hub, Haul, Extraction, Payout }

    /// <summary>
    /// Minimal, event-driven, engine-agnostic finite state machine for the top-level
    /// game flow. Pure C# so it is trivially unit-testable and reusable.
    /// Single Responsibility: it only owns the current state and validates transitions.
    /// </summary>
    public sealed class GameStateMachine
    {
        /// <summary>Raised after a successful transition (from, to).</summary>
        public event Action<GameState, GameState> StateChanged;

        public GameState Current { get; private set; } = GameState.Boot;

        // Allowed transitions table. Keeping it explicit prevents illegal jumps.
        private static bool IsAllowed(GameState from, GameState to) => (from, to) switch
        {
            (GameState.Boot, GameState.MainMenu) => true,
            (GameState.MainMenu, GameState.Lobby) => true,
            (GameState.Lobby, GameState.Hub) => true,
            (GameState.Hub, GameState.Haul) => true,
            (GameState.Haul, GameState.Extraction) => true,
            (GameState.Extraction, GameState.Payout) => true,
            (GameState.Payout, GameState.Hub) => true,
            (_, GameState.MainMenu) => true, // allow bailing to menu from anywhere
            _ => false
        };

        /// <summary>Attempts a transition; returns false (no-op) if illegal.</summary>
        public bool TryTransition(GameState to)
        {
            if (!IsAllowed(Current, to)) return false;
            var from = Current;
            Current = to;
            StateChanged?.Invoke(from, to);
            return true;
        }
    }
}

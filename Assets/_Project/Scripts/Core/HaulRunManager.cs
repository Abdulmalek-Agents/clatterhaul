using System;

namespace Clatterhaul.Core
{
    /// <summary>
    /// Owns the scoring/flow logic of a single haul run. Pure logic (no Unity scene
    /// dependencies) so the payout math is fully unit-testable and identical on all clients.
    /// The authority (host) drives it; UI/Audio observe its events.
    /// </summary>
    public sealed class HaulRunManager
    {
        public event Action<int> CheckpointReached;   // checkpoint index
        public event Action<int> RunCompleted;         // final payout

        private readonly int _baseValue;
        private readonly int _checkpointBonus;
        private int _checkpointsReached;
        private bool _completed;

        public HaulRunManager(int baseValue = 1000, int checkpointBonus = 100)
        {
            _baseValue = baseValue;
            _checkpointBonus = checkpointBonus;
        }

        public void ReachCheckpoint(int index)
        {
            if (_completed) return;
            _checkpointsReached = Math.Max(_checkpointsReached, index + 1);
            CheckpointReached?.Invoke(index);
        }

        /// <summary>
        /// Computes payout for the run. Payout = baseValue * payloadCondition
        /// + checkpointBonus * checkpoints, clamped to >= 0.
        /// </summary>
        public int ComputePayout(float payloadCondition01)
        {
            var condition = Math.Clamp(payloadCondition01, 0f, 1f);
            var raw = (int)Math.Round(_baseValue * condition) + _checkpointBonus * _checkpointsReached;
            return Math.Max(0, raw);
        }

        /// <summary>Finalizes the run and raises <see cref="RunCompleted"/> once.</summary>
        public int CompleteRun(float payloadCondition01)
        {
            if (_completed) return 0;
            _completed = true;
            var payout = ComputePayout(payloadCondition01);
            RunCompleted?.Invoke(payout);
            return payout;
        }
    }
}

using Clatterhaul.Core;
using NUnit.Framework;

namespace Clatterhaul.Tests
{
    /// <summary>EditMode tests for the pure payout/flow logic.</summary>
    public class HaulRunManagerTests
    {
        [Test]
        public void Payout_FullCondition_NoCheckpoints_EqualsBaseValue()
        {
            var run = new HaulRunManager(baseValue: 1000, checkpointBonus: 100);
            Assert.AreEqual(1000, run.ComputePayout(1f));
        }

        [Test]
        public void Payout_ScalesWithCondition()
        {
            var run = new HaulRunManager(1000, 100);
            Assert.AreEqual(500, run.ComputePayout(0.5f));
        }

        [Test]
        public void Payout_AddsCheckpointBonus()
        {
            var run = new HaulRunManager(1000, 100);
            run.ReachCheckpoint(0);
            run.ReachCheckpoint(1);
            Assert.AreEqual(1000 + 200, run.ComputePayout(1f));
        }

        [Test]
        public void CompleteRun_RaisesEventOnce()
        {
            var run = new HaulRunManager(1000, 100);
            var calls = 0;
            run.RunCompleted += _ => calls++;
            run.CompleteRun(1f);
            run.CompleteRun(1f); // second call must be a no-op
            Assert.AreEqual(1, calls);
        }
    }
}

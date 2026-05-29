using System;
using Clatterhaul.Core;
using NUnit.Framework;

namespace Clatterhaul.Tests
{
    /// <summary>EditMode tests proving the daily modifier roll is deterministic & shareable.</summary>
    public class RunModifierDeckTests
    {
        [Test]
        public void DailySeed_IsStableForSameDate()
        {
            var a = RunModifierDeck.DailySeed(new DateTime(2026, 3, 14));
            var b = RunModifierDeck.DailySeed(new DateTime(2026, 3, 14));
            Assert.AreEqual(a, b);
        }

        [Test]
        public void SelectIndices_IsDeterministicForSameSeed()
        {
            var seed = RunModifierDeck.DailySeed(new DateTime(2026, 3, 14));
            CollectionAssert.AreEqual(
                RunModifierDeck.SelectIndices(seed, 10, 3),
                RunModifierDeck.SelectIndices(seed, 10, 3));
        }

        [Test]
        public void SelectIndices_ReturnsDistinctInRange()
        {
            var picks = RunModifierDeck.SelectIndices(12345, 8, 3);
            Assert.AreEqual(3, picks.Length);
            CollectionAssert.AllItemsAreUnique(picks);
            foreach (var p in picks) Assert.That(p, Is.InRange(0, 7));
        }

        [Test]
        public void SelectIndices_ClampsCountToPoolSize()
        {
            var picks = RunModifierDeck.SelectIndices(1, 2, 5);
            Assert.AreEqual(2, picks.Length);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Clatterhaul.Core
{
    /// <summary>
    /// Deterministic daily-modifier selection. Because the seed derives only from the
    /// UTC date, every friend in a session rolls the SAME daily modifiers without any
    /// network sync. Pure & static so it is fully unit-testable.
    /// </summary>
    public static class RunModifierDeck
    {
        /// <summary>Stable seed for a given UTC calendar day.</summary>
        public static int DailySeed(DateTime utcDate)
            => utcDate.Year * 10000 + utcDate.Month * 100 + utcDate.Day;

        /// <summary>
        /// Picks <paramref name="count"/> distinct indices in [0, poolSize) deterministically
        /// from <paramref name="seed"/>. Returns fewer if the pool is smaller than count.
        /// </summary>
        public static int[] SelectIndices(int seed, int poolSize, int count)
        {
            if (poolSize <= 0 || count <= 0) return Array.Empty<int>();
            count = Math.Min(count, poolSize);

            // Simple deterministic shuffle (Fisher-Yates) driven by a stable LCG.
            var indices = new List<int>(poolSize);
            for (var i = 0; i < poolSize; i++) indices.Add(i);

            var state = unchecked((uint)seed * 2654435761u + 1u); // Knuth multiplicative
            uint Next() { state = unchecked(state * 1664525u + 1013904223u); return state; }

            for (var i = poolSize - 1; i > 0; i--)
            {
                var j = (int)(Next() % (uint)(i + 1));
                (indices[i], indices[j]) = (indices[j], indices[i]);
            }

            var result = new int[count];
            indices.CopyTo(0, result, 0, count);
            return result;
        }
    }
}

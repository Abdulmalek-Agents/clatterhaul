using UnityEngine;

namespace Clatterhaul.Core
{
    /// <summary>
    /// Data-driven run modifier ("low gravity", "greased joints", "storm"...).
    /// Designers author these as assets; no code change needed to add a modifier.
    /// </summary>
    [CreateAssetMenu(menuName = "Clatterhaul/Run Modifier", fileName = "RunModifier")]
    public sealed class RunModifier : ScriptableObject
    {
        [Tooltip("Stable unique id used for the daily seed and telemetry.")]
        public string id = "low_gravity";
        public string displayName = "Low Gravity";
        [TextArea] public string description = "The world feels lighter. So does your judgement.";

        [Header("Tunables (1 = unchanged)")]
        [Range(0.1f, 2f)] public float gravityScale = 1f;
        [Range(0.25f, 2f)] public float jointStrengthMultiplier = 1f;
        [Range(0.25f, 2f)] public float payloadFragilityMultiplier = 1f;
        public bool nightTime = false;
    }
}

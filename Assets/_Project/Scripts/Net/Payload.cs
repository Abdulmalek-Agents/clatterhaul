using Clatterhaul.Core;
using Mirror;
using UnityEngine;

namespace Clatterhaul.Net
{
    /// <summary>
    /// The precious cargo. Condition is server-authoritative and synced to all clients so
    /// the HUD and final payout agree. Damage comes from impacts/submersion/hazards.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public sealed class Payload : NetworkBehaviour, IPayload
    {
        [SerializeField] private float impactDamageScale = 0.02f;
        [SerializeField] private float fragilityMultiplier = 1f; // raised by 'fragile cargo' modifier

        [SyncVar] private float _condition01 = 1f;
        public float Condition01 => _condition01;

        public void ApplyDamage(float amount, string cause)
        {
            if (!isServer) return;
            _condition01 = Mathf.Clamp01(_condition01 - amount * fragilityMultiplier);
            // TODO: raise a synced event for HUD feedback + audio cue.
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (!isServer) return;
            var impact = collision.relativeVelocity.magnitude;
            if (impact > 3f) ApplyDamage(impact * impactDamageScale, "impact");
        }
    }
}

using Mirror;
using UnityEngine;

namespace Clatterhaul.Net
{
    public enum ModuleCategory { Chassis, Locomotion, Lift, Stabilizer, Cosmetic }

    /// <summary>
    /// Base for every contraption part. Handles breakable joints and broadcasts breakage
    /// for VFX/SFX/disaster-cam. Concrete modules (Wheel, Leg, Balloon...) derive from this.
    /// </summary>
    public class ContraptionModule : NetworkBehaviour
    {
        [SerializeField] private ModuleCategory category = ModuleCategory.Locomotion;
        [SerializeField] private float breakForce = 6000f;
        [SerializeField] private float breakTorque = 6000f;

        public ModuleCategory Category => category;

        protected virtual void Start()
        {
            // Joints are configured by the assembly system; here we just arm break thresholds.
            foreach (var joint in GetComponents<Joint>())
            {
                joint.breakForce = breakForce;
                joint.breakTorque = breakTorque;
            }
        }

        // Unity calls this on the body when one of its joints breaks (server simulates).
        private void OnJointBreak(float breakImpulse)
        {
            if (!isServer) return;
            RpcOnModuleBroke(breakImpulse);
        }

        [ClientRpc]
        private void RpcOnModuleBroke(float impulse)
        {
            // TODO(M3): spawn debris from pool, play strain-snap SFX, trigger disaster-cam if severe.
            Debug.Log($"[Contraption] {category} module broke (impulse {impulse:0}).");
        }
    }
}

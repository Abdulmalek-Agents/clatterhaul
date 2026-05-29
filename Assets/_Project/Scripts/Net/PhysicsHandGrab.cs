using Clatterhaul.Core;
using Mirror;
using UnityEngine;

namespace Clatterhaul.Net
{
    /// <summary>
    /// Human-Fall-Flat-style physics grab. The grab INTENT is a Command; the actual joint
    /// is created on the server (host) only, keeping a single physics authority (TDD §2/§3).
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public sealed class PhysicsHandGrab : NetworkBehaviour
    {
        [SerializeField] private float reach = 1.2f;
        [SerializeField] private float grabSpring = 2000f;
        [SerializeField] private float grabDamper = 50f;

        private Rigidbody _hand;
        private ConfigurableJoint _activeJoint; // server-only

        private void Awake() => _hand = GetComponent<Rigidbody>();

        /// <summary>Called by local input on the owning client.</summary>
        public void TryGrab()
        {
            if (isOwned) CmdGrab(transform.position, transform.forward);
        }

        public void Release()
        {
            if (isOwned) CmdRelease();
        }

        [Command]
        private void CmdGrab(Vector3 origin, Vector3 dir)
        {
            // Server authority: find a grabbable in reach and attach a spring joint.
            if (_activeJoint != null) return;
            if (Physics.SphereCast(origin, 0.15f, dir, out var hit, reach) &&
                hit.rigidbody != null && hit.collider.TryGetComponent<IGrabbable>(out var grabbable))
            {
                _activeJoint = _hand.gameObject.AddComponent<ConfigurableJoint>();
                _activeJoint.connectedBody = hit.rigidbody;
                _activeJoint.autoConfigureConnectedAnchor = false;
                _activeJoint.connectedAnchor = hit.rigidbody.transform.InverseTransformPoint(hit.point);
                var drive = new JointDrive { positionSpring = grabSpring, positionDamper = grabDamper, maximumForce = Mathf.Infinity };
                _activeJoint.xDrive = _activeJoint.yDrive = _activeJoint.zDrive = drive;
                grabbable.OnGrabbed(gameObject);
            }
        }

        [Command]
        private void CmdRelease()
        {
            if (_activeJoint == null) return;
            if (_activeJoint.connectedBody != null &&
                _activeJoint.connectedBody.TryGetComponent<IGrabbable>(out var grabbable))
                grabbable.OnReleased(gameObject);
            Destroy(_activeJoint);
            _activeJoint = null;
        }
    }
}

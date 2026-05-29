using Clatterhaul.Core;
using Mirror;
using UnityEngine;

namespace Clatterhaul.Net
{
    /// <summary>
    /// A control point (steer/pedal/crank/sail). Occupancy is networked; control input is
    /// applied on the server authority. Implements <see cref="IStation"/> and
    /// <see cref="IInteractable"/> so gameplay code stays transport-agnostic.
    /// </summary>
    public sealed class ContraptionStation : NetworkBehaviour, IStation, IInteractable
    {
        [SerializeField] private string prompt = "Use station";
        [SyncVar] private uint _occupantNetId;

        public bool IsOccupied => _occupantNetId != 0;
        public string Prompt => prompt;

        public bool CanInteract(GameObject interactor) => !IsOccupied;
        public void Interact(GameObject interactor)
        {
            if (interactor.TryGetComponent<NetworkIdentity>(out var id)) CmdOccupy(id.netId);
        }

        [Command(requiresAuthority = false)]
        private void CmdOccupy(uint netId) { if (!IsOccupied) _occupantNetId = netId; }

        public void Occupy(GameObject player) { if (player.TryGetComponent<NetworkIdentity>(out var id)) CmdOccupy(id.netId); }
        public void Vacate() => CmdVacate();

        [Command(requiresAuthority = false)]
        private void CmdVacate() => _occupantNetId = 0;

        /// <summary>Applies normalized control on the server (e.g. wheel torque, sail trim).</summary>
        public void ApplyControl(Vector2 input)
        {
            if (!isServer) return;
            // TODO(M3): map input to this station's actuator (motor torque / steer angle / sail force).
        }
    }
}

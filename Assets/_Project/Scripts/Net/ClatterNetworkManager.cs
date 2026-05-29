// Requires the Mirror package (see docs/04_UNITY_ASSET_INTEGRATION.md).
using Mirror;
using UnityEngine;

namespace Clatterhaul.Net
{
    /// <summary>
    /// Host-authoritative network manager for Clatterhaul. Hosts simulate ALL physics;
    /// clients send input and interpolate. Extends Mirror's NetworkManager so we keep
    /// Mirror's lobby/spawn lifecycle while injecting our hub/run flow.
    /// </summary>
    public sealed class ClatterNetworkManager : NetworkManager
    {
        [Header("Clatterhaul")]
        [Tooltip("Max crew size; design target is 2-4.")]
        [SerializeField] private int maxCrew = 4;

        public override void Awake()
        {
            base.Awake();
            maxConnections = Mathf.Clamp(maxCrew, 2, 4);
        }

        /// <summary>Spawns the crew member prefab for a joining client (server side).</summary>
        public override void OnServerAddPlayer(NetworkConnectionToClient conn)
        {
            // TODO(M1): spawn at the hub spawn ring; assign a free station slot if mid-hub.
            base.OnServerAddPlayer(conn);
            Debug.Log($"[Net] Crew member added: conn {conn.connectionId}. Crew = {numPlayers}/{maxConnections}.");
        }

        /// <summary>Host left: end the run gracefully (no host migration at launch — see TDD §2).</summary>
        public override void OnStopServer()
        {
            base.OnStopServer();
            Debug.Log("[Net] Server stopped — run ended. (Host migration is a post-launch item.)");
        }
    }
}

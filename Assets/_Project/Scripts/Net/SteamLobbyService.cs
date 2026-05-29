using System;
using UnityEngine;

namespace Clatterhaul.Net
{
    /// <summary>
    /// Thin abstraction over Steam lobbies/invites. Kept free of direct Steamworks.NET
    /// type references so the project compiles before the SDK is imported; the marked
    /// TODOs are where Steamworks.NET / FizzySteamworks calls slot in (see docs/04).
    /// Exposes plain events so gameplay/UI never depend on Steam directly (SOLID).
    /// </summary>
    public sealed class SteamLobbyService : MonoBehaviour
    {
        public event Action LobbyCreated;
        public event Action<ulong> LobbyJoined;   // lobbyId
        public event Action<string> LobbyError;

        /// <summary>Create a friends-only lobby and start Mirror as host.</summary>
        public void CreateLobby()
        {
            // TODO(M1): SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, maxMembers);
            //           On callback success -> NetworkManager.singleton.StartHost();
            Debug.Log("[Steam] CreateLobby requested (stub).");
            LobbyCreated?.Invoke();
        }

        /// <summary>Join a lobby from a Steam invite / overlay.</summary>
        public void JoinLobby(ulong lobbyId)
        {
            // TODO(M1): SteamMatchmaking.JoinLobby(lobbyId); set NetworkManager address to host SteamID; StartClient();
            Debug.Log($"[Steam] JoinLobby {lobbyId} (stub).");
            LobbyJoined?.Invoke(lobbyId);
        }
    }
}

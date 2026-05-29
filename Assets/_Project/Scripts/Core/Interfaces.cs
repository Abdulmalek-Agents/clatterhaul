using UnityEngine;

namespace Clatterhaul.Core
{
    /// <summary>Anything a player can trigger with the context-interact button.</summary>
    public interface IInteractable
    {
        /// <summary>Localized prompt shown when in range (e.g. "Take the wheel").</summary>
        string Prompt { get; }
        bool CanInteract(GameObject interactor);
        void Interact(GameObject interactor);
    }

    /// <summary>Anything the physics-hands can grab (props, cargo, ropes).</summary>
    public interface IGrabbable
    {
        Rigidbody Body { get; }
        bool IsGrabbed { get; }
        void OnGrabbed(GameObject hand);
        void OnReleased(GameObject hand);
    }

    /// <summary>A control point on the contraption (steer/pedal/crank/sail).</summary>
    public interface IStation
    {
        bool IsOccupied { get; }
        void Occupy(GameObject player);
        void Vacate();
        /// <summary>Applies normalized control input (-1..1 per axis) on the authority.</summary>
        void ApplyControl(Vector2 input);
    }

    /// <summary>The precious, fragile cargo whose surviving condition drives payout.</summary>
    public interface IPayload
    {
        /// <summary>Remaining condition 0..1; payout scales with this.</summary>
        float Condition01 { get; }
        void ApplyDamage(float amount, string cause);
    }

    /// <summary>Marker for environmental hazards (for logging/telemetry/QA).</summary>
    public interface IHazard { string HazardId { get; } }
}

using UnityEngine;

namespace LeoIntegration
{
    public class OnCollisionExitChecker : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            EcsPhysicsEvents.RegisterCollisionExitEvent(gameObject, other.collider, other.relativeVelocity);
        }
    }
}
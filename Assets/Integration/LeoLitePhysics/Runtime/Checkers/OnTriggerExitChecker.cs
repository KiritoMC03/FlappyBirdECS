using UnityEngine;

namespace LeoIntegration
{
    public class OnTriggerExitChecker : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            EcsPhysicsEvents.RegisterTriggerExitEvent(gameObject, other);
        }
    }
}
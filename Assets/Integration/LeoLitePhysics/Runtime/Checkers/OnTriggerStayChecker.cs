using UnityEngine;

namespace LeoIntegration
{
    public class OnTriggerStayChecker : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            EcsPhysicsEvents.RegisterTriggerStayEvent(gameObject, other);
        }
    }
}
using UnityEngine;

namespace LeoIntegration
{
    public class OnTriggerEnterChecker : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        { 
            EcsPhysicsEvents.RegisterTriggerEnterEvent(gameObject, other);
        }
    }
}

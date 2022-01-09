using UnityEngine;

namespace LeoIntegration
{
    public struct OnCollisionExitEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
        public Vector3 relativeVelocity;
    }
}
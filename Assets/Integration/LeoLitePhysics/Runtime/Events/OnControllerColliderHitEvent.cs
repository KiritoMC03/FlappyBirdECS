using UnityEngine;

namespace LeoIntegration
{
    public struct OnControllerColliderHitEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
        public Vector3 hitNormal;
        public Vector3 moveDirection;
    }
}
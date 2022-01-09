using Leopotam.EcsLite;
using UnityEngine;

namespace LeoIntegration
{
    public class EcsPhysicsEvents
    {
        private static EcsWorld _eventsWorld;

        public static void Init(EcsWorld eventsWorld)
        {
            if (eventsWorld == null)
            {
                Debug.LogError($"{nameof(eventsWorld)} in null.");
                return;
            }

            _eventsWorld = eventsWorld;
        }
        
        public static void RegisterTriggerEnterEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnTriggerEnterEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterTriggerStayEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnTriggerStayEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterTriggerExitEvent(GameObject senderGameObject, Collider collider)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnTriggerExitEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
        }

        public static void RegisterCollisionEnterEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnCollisionEnterEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterCollisionStayEvent(GameObject senderGameObject, Collider collider, ContactPoint firstContactPoint, Vector3 relativeVelocity)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnCollisionStayEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.firstContactPoint = firstContactPoint;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterCollisionExitEvent(GameObject senderGameObject, Collider collider, Vector3 relativeVelocity)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnCollisionExitEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.relativeVelocity = relativeVelocity;
        }

        public static void RegisterControllerColliderHitEvent(GameObject senderGameObject, Collider collider, Vector3 hitNormal, Vector3 moveDirection)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnControllerColliderHitEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider = collider;
            eventComponent.hitNormal = hitNormal;
            eventComponent.moveDirection = moveDirection;
        }
        
        public static void RegisterCollisionEnter2DEvent(GameObject senderGameObject, Collider2D collider2D, ContactPoint2D firstContactPoint2D, Vector2 relativeVelocity)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnCollisionEnter2DEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
            eventComponent.firstContactPoint2D = firstContactPoint2D;
            eventComponent.relativeVelocity = relativeVelocity;
        }
        
        public static void RegisterCollisionStay2DEvent(GameObject senderGameObject, Collider2D collider2D, ContactPoint2D firstContactPoint2D, Vector2 relativeVelocity)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnCollisionStay2DEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
            eventComponent.firstContactPoint2D = firstContactPoint2D;
            eventComponent.relativeVelocity = relativeVelocity;
        }
        
        public static void RegisterCollisionExit2DEvent(GameObject senderGameObject, Collider2D collider2D, Vector2 relativeVelocity)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnCollisionExit2DEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
            eventComponent.relativeVelocity = relativeVelocity;
        }
        
        public static void RegisterTriggerEnter2DEvent(GameObject senderGameObject, Collider2D collider2D)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnTriggerEnter2DEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
        }
        
        public static void RegisterTriggerStay2DEvent(GameObject senderGameObject, Collider2D collider2D)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnTriggerStay2DEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
        }
        
        public static void RegisterTriggerExit2DEvent(GameObject senderGameObject, Collider2D collider2D)
        {
            var eventEntity = _eventsWorld.NewEntity();
            ref var eventComponent = ref _eventsWorld.GetPool<OnTriggerExit2DEvent>().Add(eventEntity);
            eventComponent.senderGameObject = senderGameObject;
            eventComponent.collider2D = collider2D;
        }
    }
}
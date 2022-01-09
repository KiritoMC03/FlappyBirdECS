using LeoIntegration;
using Leopotam.EcsLite;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class OnTriggerEnterEventListener : IEcsRunSystem
    {
        public void Run(EcsSystems systems)
        {
            var world = systems.GetWorld(CustomWorlds.Events.ToString());
            var filter = world.Filter<OnTriggerEnterEvent>().End();
            var trigenterpool = world.GetPool<OnTriggerEnterEvent>();

            foreach (var entity in filter)
            {
                ref var current = ref trigenterpool.Get(entity);
                Debug.Log($"Trigger: {current.senderGameObject}, {current.collider}");
            }
        }
    }
}
using LeoIntegration;
using Leopotam.EcsLite;

namespace Integration
{
    public class PhysicsInitSystem : IEcsPreInitSystem
    {
        public void PreInit(EcsSystems systems)
        {
            EcsPhysicsEvents.Init(systems.GetWorld(CustomWorlds.Events.ToString()));
        }
    }
}
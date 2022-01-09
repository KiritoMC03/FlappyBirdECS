using Leopotam.EcsLite;
using Leopotam.EcsLite.ExtendedSystems;

namespace LeoIntegration
{
    public static class EcsSystemsExtensions
    {
        public static EcsSystems DelHerePhysics(this EcsSystems ecsSystems)
        {
            ecsSystems.DelHere<OnTriggerEnterEvent>(CustomWorlds.Events.ToString());
            ecsSystems.DelHere<OnTriggerStayEvent>(CustomWorlds.Events.ToString());
            ecsSystems.DelHere<OnTriggerExitEvent>(CustomWorlds.Events.ToString());
            ecsSystems.DelHere<OnCollisionEnterEvent>(CustomWorlds.Events.ToString());
            ecsSystems.DelHere<OnCollisionStayEvent>(CustomWorlds.Events.ToString());
            ecsSystems.DelHere<OnCollisionExitEvent>(CustomWorlds.Events.ToString());
            ecsSystems.DelHere<OnControllerColliderHitEvent>(CustomWorlds.Events.ToString());

            return ecsSystems;
        }
    }
}
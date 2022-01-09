using DefaultNamespace;
using Integration;
using LeoIntegration;
using Leopotam.EcsLite;
using UnityEngine;
using Voody.UniLeo.Lite;

namespace Client
{
    sealed class EcsStartup : MonoBehaviour
    {
        EcsSystems _systems;

        void Start()
        {
            _systems = new EcsSystems(new EcsWorld());
            _systems
                .AddWorld(new EcsWorld(), CustomWorlds.Events.ToString())
                .Add(new PhysicsInitSystem())
                .Add(new OnTriggerEnterEventListener())
                .DelHerePhysics()
#if UNITY_EDITOR
                .Add(new Leopotam.EcsLite.UnityEditor.EcsWorldDebugSystem())
                .Add(new Leopotam.EcsLite.UnityEditor.EcsWorldDebugSystem(CustomWorlds.Events.ToString()))
#endif
                .ConvertScene()
                .Init();
        }

        void Update()
        {
            _systems?.Run();
        }

        void OnDestroy()
        {
            if (_systems != null)
            {
                _systems.Destroy();
                _systems.GetWorld(CustomWorlds.Events.ToString()).Destroy();
                _systems.GetWorld().Destroy();
                _systems = null;
            }
        }

        public EcsSystems GetSystems()
        {
            return _systems;
        }
    }
}
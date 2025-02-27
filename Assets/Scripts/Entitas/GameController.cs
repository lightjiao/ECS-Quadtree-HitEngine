﻿using Entitas;
using UnityEngine;

namespace HitEngine.Entitas
{
    public class GameController : MonoBehaviour
    {
        private Systems _systems;

        // Start is called before the first frame update
        private void Start()
        {
            var contexts = Contexts.sharedInstance;

            var initFeature = new Feature("Init");
            initFeature.Add(new RenderBackground(contexts));
            initFeature.Add(new InitSystem(contexts));

            _systems = new Feature("System")
                .Add(initFeature)
                .Add(new MoveFeature(contexts))
                .Add(new HitEngineFeature(contexts))
                .Add(new ViewFeature(contexts));

            _systems.Initialize();
        }

        // Update is called once per frame
        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}
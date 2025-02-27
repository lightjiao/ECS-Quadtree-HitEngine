﻿namespace HitEngine.Entitas
{
    public class ViewFeature : Feature
    {
        public ViewFeature(Contexts contexts) : base("ViewFeature")
        {
            Add(new AddViewSystem(contexts));
            Add(new RenderPositionSystem(contexts));
            Add(new RenderHitableSystem(contexts));
            Add(new RenderInHitSystem(contexts));
        }
    }
}
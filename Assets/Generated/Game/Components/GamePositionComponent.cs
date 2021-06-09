//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public HitEngine.Entitas.PositionComponent position { get { return (HitEngine.Entitas.PositionComponent)GetComponent(GameComponentsLookup.Position); } }
    public bool hasPosition { get { return HasComponent(GameComponentsLookup.Position); } }

    public void AddPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.Position;
        var component = (HitEngine.Entitas.PositionComponent)CreateComponent(index, typeof(HitEngine.Entitas.PositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.Position;
        var component = (HitEngine.Entitas.PositionComponent)CreateComponent(index, typeof(HitEngine.Entitas.PositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(GameComponentsLookup.Position);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPosition;

    public static Entitas.IMatcher<GameEntity> Position {
        get {
            if (_matcherPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Position);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}

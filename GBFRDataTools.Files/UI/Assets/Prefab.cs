using GBFRDataTools.Files.UI.Components;

using System.Numerics;

namespace GBFRDataTools.Files.UI.Assets;

// prfb - ui::asset::Prefab
// note: files:
// - 38726B07D5C46210
// - 45398097E6451A84
// - 49B50479B0C88573
// - 5D1405DEDDD277CF
// - 5E24A1AD2845A142
// - 607B60A5AF8AB64A
// - 980E92DA545B6C6A
// - B4318E784D3EC0E7
// - E6AA6952D620558F
// has it in msg format
public class Prefab
{
    public List<Object> Objects { get; set; }
}

// ui::Object
public class Object
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> Children { get; set; }
    public List<ComponentThing> Components { get; set; }

    public bool Active { get; set; }
    public Vector3 Position { get; set; }
    public Vector4 Rotation { get; set; }
    public Vector3 Scale { get; set; }
    public Vector2 Pivot { get; set; }
    public Vector2 AnchorPoint { get; set; }
    public Vector2 AnchorMin { get; set; }
    public Vector2 AnchorMax { get; set; }
    public Vector2 OffsetMin { get; set; }
    public Vector2 OffsetMax { get; set; }
    public Vector2 SizeDelta { get; set; }
}

public class ComponentThing
{
    public string ComponentName { get; set; }
    public Component Component { get; set; }
}
using System.Numerics;

namespace GBFRDataTools.Files.UI.Assets;

// viewb - ui::asset::View
// note: file 49891858950C901A has it in msg format
public class View
{
    public List<Layout> Layouts { get; set; }
}

public class Layout
{
    public Vector4 Rotation { get; set; }
    public Vector3 Scale { get; set; }
    public Vector2 Pivot { get; set; }
    public Vector2 AnchorPoint { get; set; }
    public Vector2 AnchorMin { get; set; }
    public Vector2 AnchorMax { get; set; }
    public Vector2 SizeDelta { get; set; }
    public Vector2 OffsetMin { get; set; }
    public Vector2 OffsetMax { get; set; }
    public bool Active { get; set; }
    public string AssetPath { get; set; }
}

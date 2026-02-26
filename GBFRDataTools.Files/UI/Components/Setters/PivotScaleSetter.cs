using System.Numerics;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::PivotScaleSetter
public class PivotScaleSetter : Component
{
    public Vector2 Scale { get; set; }
    public Vector2 Offset { get; set; }
    public Vector2 Pivot { get; set; }
}

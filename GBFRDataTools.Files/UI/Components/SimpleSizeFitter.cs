using GBFRDataTools.Files.UI.Types;

using System.Numerics;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SimpleSizeFitter
public class SimpleSizeFitter : Component
{
    public UIObjectRef Target { get; set; }
    public bool IgnoreX { get; set; }
    public bool IgnoreY { get; set; }
    public Vector2 Padding { get; set; }
}

using System.Numerics;

namespace GBFRDataTools.Files.UI.Components.LayoutGroups;

// ui::component::LayoutGroup
public class LayoutGroup : Component
{
    public Vector4 Padding { get; set; }
    public float Spacing { get; set; }
    public int ChildAlignment { get; set; }
    public bool ChildControlWidth { get; set; }
    public bool ChildControlHeight { get; set; }
    public bool ChildScaleWidth { get; set; }
    public bool ChildScaleHeight { get; set; }
    public bool ChildForceExpandWidth { get; set; }
    public bool ChildForceExpandHeight { get; set; }
}

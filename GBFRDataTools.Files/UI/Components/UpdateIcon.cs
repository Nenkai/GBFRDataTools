using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::UpdateIcon
public class UpdateIcon : Component
{
    public UIObjectRef Animator { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef ImageSetter { get; set; }
    public int Size { get; set; }
}

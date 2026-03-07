using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.IconSetters;

// ui::component::IconSetter
public class IconSetter : Component
{
    public UIObjectRef Target { get; set; }
    public bool Resetting { get; set; }
}

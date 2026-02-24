using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::MaterialSetter
public class MaterialSetter : Component
{
    public UIObjectRef Target { get; set; }
    public UIObjectRef TargetRaw { get; set; }
    public List<UIObjectRef> Materials { get; set; }
}

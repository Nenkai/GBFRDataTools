using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::CharaColorInfo
public class CharaColorInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public UIObjectRef LeftColorImage { get; set; }
    public UIObjectRef RightColorImage { get; set; }
    public UIObjectRef Icon { get; set; }
}

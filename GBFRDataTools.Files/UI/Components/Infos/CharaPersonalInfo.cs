using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::CharaPersonalInfo
public class CharaPersonalInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Text { get; set; }
}

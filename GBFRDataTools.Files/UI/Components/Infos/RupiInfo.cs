using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::RupiInfo
public class RupiInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> HideImages { get; set; }
    public UIObjectRef Rupi { get; set; }
    public UIObjectRef Title { get; set; }
    public UIObjectRef Info { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef BgImageSetter { get; set; }
}

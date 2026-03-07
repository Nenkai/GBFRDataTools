using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::SkinInfo
public class SkinInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public UIObjectRef Skin { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef Info { get; set; }
    public UIObjectRef EquipIcon { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
}

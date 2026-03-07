using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::PlayerCardInfo
public class PlayerCardInfo : Component
{
    public int NameType { get; set; }
    public int CharaType { get; set; }
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> OnlineIDs { get; set; }
    public sbyte _C66A07D4 { get; set; }
    public List<UIObjectRef> CharaIcons { get; set; }
    public List<UIObjectRef> EmptyCharaIcons { get; set; }
    public bool NoNameDispID { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
}

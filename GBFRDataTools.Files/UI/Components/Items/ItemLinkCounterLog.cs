using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemLinkCounterLog
public class ItemLinkCounterLog : Component
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef CharaInfo { get; set; }
    public UIObjectRef TextAction { get; set; }
    public UIObjectRef TextNum { get; set; }
    public UIObjectRef TextPt { get; set; }
    public UIObjectRef MiniCharaIcon { get; set; }
    public UIObjectRef SpArtsIcon { get; set; }
    public UIObjectRef ManualMat { get; set; }
    public UIObjectRef PartyMat { get; set; }
}

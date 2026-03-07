using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::MspUsedItemInfo
public class MspUsedItemInfo : Component
{
    public List<UIObjectRef> RazielRoots { get; set; }
    public List<UIObjectRef> AmbrosiaRoots { get; set; }
    public List<UIObjectRef> AmbrosiaEmptys { get; set; }
    public List<UIObjectRef> LocalizeEmptys { get; set; }
    public List<UIObjectRef> MspGets { get; set; }
    public UIObjectRef MaxMsp { get; set; }
    public UIObjectRef OverMsp { get; set; }
    public UIObjectRef PrevText { get; set; }
    public UIObjectRef CompareText { get; set; }
    public UIObjectRef GetMspText { get; set; }
}

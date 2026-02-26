using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::BadgeInfo
public class BadgeInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public List<UIObjectRef> GoldObjs { get; set; }
    public List<UIObjectRef> SilverObjs { get; set; }
    public List<UIObjectRef> CopperObjs { get; set; }
    public List<UIObjectRef> OneLayerObjs { get; set; }
    public List<UIObjectRef> FrameImages { get; set; }
    public int TitleType { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef Explanation { get; set; }
    public UIObjectRef Category { get; set; }
}

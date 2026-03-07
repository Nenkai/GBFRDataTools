using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemQuestDetailBahaChara
public class ItemQuestDetailBahaChara : Component
{
    public List<UIObjectRef> ReleaseObjs { get; set; }
    public UIObjectRef NoReleaseObj { get; set; }
    public UIObjectRef CharaIcon { get; set; }
    public UIObjectRef CharaImage { get; set; }
}

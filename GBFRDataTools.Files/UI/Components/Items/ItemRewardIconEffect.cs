using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemRewardIconEffect
public class ItemRewardIconEffect : Component
{
    public List<UIObjectRef> LowObjs { get; set; }
    public List<UIObjectRef> MiddleObjs { get; set; }
    public List<UIObjectRef> HighObjs { get; set; }
    public List<UIObjectRef> VeryHighObjs { get; set; }
    public List<UIObjectRef> AuraTextures { get; set; }
    public List<UIObjectRef> KiraTextures { get; set; }
    public List<UIObjectRef> AuraColors { get; set; }
}

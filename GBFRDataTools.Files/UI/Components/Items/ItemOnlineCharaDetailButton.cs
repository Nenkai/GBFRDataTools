using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemOnlineCharaDetailButton
public class ItemOnlineCharaDetailButton : Component
{
    public List<UIObjectRef> Obj { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public List<UIObjectRef> GrayOutImages { get; set; }
    public List<UIObjectRef> GrayOutTexts { get; set; }
    public UIObjectRef Button { get; set; }
}

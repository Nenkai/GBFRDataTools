using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemListText
public class ItemListText : Component
{
    public List<UIObjectRef> MirageSets { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef Plus { get; set; }
    public UIObjectRef Unit { get; set; }
    public UIObjectRef Level { get; set; }
    public UIObjectRef LevelBg { get; set; }
}

using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemObtainLocation
public class ItemObtainLocation : Component
{
    public List<UIObjectRef> Timer { get; set; }
    public List<UIObjectRef> LocationText { get; set; }
    public List<UIObjectRef> ValueText { get; set; }
    public UIObjectRef IconImage { get; set; }
    public UIObjectRef TitleText { get; set; }
    public UIObjectRef IconSlash { get; set; }
    public UIObjectRef QuestInfo { get; set; }
}

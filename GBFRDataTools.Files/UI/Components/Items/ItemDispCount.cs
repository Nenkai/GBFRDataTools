using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemDispCount
public class ItemDispCount : Component
{
    public List<UIObjectRef> CompareSets { get; set; }
    public List<UIObjectRef> CompareEmpties { get; set; }
    public List<UIObjectRef> IconSets { get; set; }
    public List<UIObjectRef> IconEmpties { get; set; }
    public UIObjectRef BeforeCount { get; set; }
    public UIObjectRef AfterCount { get; set; }
    public UIObjectRef Icon { get; set; }
}

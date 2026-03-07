using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemButtonText
public class ItemButtonText : Component
{
    public List<UIObjectRef> Texts { get; set; }
    public UIObjectRef Button { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
}

using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemStar
public class ItemStar : Component
{
    public List<UIObjectRef> Stars { get; set; }
    public List<UIObjectRef> StarAnimations { get; set; }
    public int AnimationType { get; set; }
}

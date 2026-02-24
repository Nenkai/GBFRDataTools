using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemQuestRankTab
public class ItemQuestRankTab : Component
{
    public List<UIObjectRef> Texts { get; set; }
    public UIObjectRef TabFrameIamge { get; set; } // Cy typo - "Image" -> "Iamge"
    public UIObjectRef TabFrameImageSetter { get; set; }
    public UIObjectRef Button { get; set; }
    public int TabPosition { get; set; }
}

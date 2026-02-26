using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::QuestRankTextColorSetter
public class QuestRankTextColorSetter : Component
{
    public int Type { get; set; }
    public List<UIObjectRef> RankTexts { get; set; }
}

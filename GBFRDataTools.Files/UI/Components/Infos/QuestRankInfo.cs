using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::QuestRankInfo
public class QuestRankInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> RankNames { get; set; }
    public List<UIObjectRef> RankTextColorSetters { get; set; }
    public List<UIObjectRef> MultiQuestTypeIcons { get; set; }
    public List<UIObjectRef> MultiQuestTypeObjects { get; set; }
    public List<UIObjectRef> QuestRankImages { get; set; }
}

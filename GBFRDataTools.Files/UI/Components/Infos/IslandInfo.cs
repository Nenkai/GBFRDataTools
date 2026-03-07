using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::IslandInfo
public class IslandInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Release { get; set; }
    public List<UIObjectRef> KeyQuestObjects { get; set; }
    public List<UIObjectRef> RankupQuestObjects { get; set; }
    public UIObjectRef IslandName { get; set; }
    public List<UIObjectRef> IslandNames { get; set; }
    public List<UIObjectRef> KeyQuestCounts { get; set; }
    public List<UIObjectRef> RankupQuestCounts { get; set; }
}

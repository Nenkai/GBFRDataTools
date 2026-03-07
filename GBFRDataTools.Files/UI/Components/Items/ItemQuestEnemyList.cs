using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemQuestEnemyList
public class ItemQuestEnemyList : Component
{
    public List<UIObjectRef> CharaIconObjs { get; set; }
    public List<UIObjectRef> CharaIcons { get; set; }
    public List<UIObjectRef> _00BF7AAF { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef Element { get; set; }
    public UIObjectRef BossIconObj { get; set; }
    public UIObjectRef CharIconsObj { get; set; }
}

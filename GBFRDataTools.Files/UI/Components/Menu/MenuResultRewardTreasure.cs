using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::MenuResultRewardTreasure
public class MenuResultRewardTreasure : Menu
{
    public List<UIObjectRef> LineTileList { get; set; }
    public UIObjectRef TitleText { get; set; }
    public UIObjectRef TitleLineBG { get; set; }
    public UIObjectRef EmptyTextObject { get; set; }
    public UIObjectRef OwnerObject { get; set; }
}

using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::MenuOnlinePlayerListDetail
public class MenuOnlinePlayerListDetail : Menu
{
    public UIObjectRef CharaInfo { get; set; }
    public UIObjectRef PlayerCardInfo { get; set; }
    public List<UIObjectRef> SwichNameTextList { get; set; }
}

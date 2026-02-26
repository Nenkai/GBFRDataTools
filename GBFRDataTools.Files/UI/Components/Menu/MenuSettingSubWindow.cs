using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::MenuSettingSubWindow
public class MenuSettingSubWindow : Menu
{
    public UIObjectRef SelectItemInfo { get; set; }
    public List<UIObjectRef> AssistIcons { get; set; }
    public List<UIObjectRef> SuperAssistIcons { get; set; }
}

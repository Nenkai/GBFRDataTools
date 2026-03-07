using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::MenuNeedMaterialChoice
public class MenuNeedMaterialChoice : Menu
{
    public int Mode { get; set; }
    public UIObjectRef ErrorText { get; set; }
    public UIObjectRef WarningText { get; set; }
    public UIObjectRef WarningTextRoot { get; set; }
}

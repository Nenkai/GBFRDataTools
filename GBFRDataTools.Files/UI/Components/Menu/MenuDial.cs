using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::MenuDial
public class MenuDial : Menu
{
    public UIObjectRef Arrow { get; set; }
    public List<UIObjectRef> ArrowRawImages { get; set; }
    public List<UIObjectRef> ArrowMaterials { get; set; }
    public int ColorMode { get; set; }
}

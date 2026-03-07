using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerGuessCharaSelectSkin
public class ControllerGuessCharaSelectSkin : Controller
{
    public UIObjectRef Menu { get; set; }
    public UIObjectRef CurrentSkinInfo { get; set; }
    public List<UIObjectRef> LineSeparateList { get; set; }
}

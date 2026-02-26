using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerFavDetail
public class ControllerFavDetail : Controller
{
    public UIObjectRef Material { get; set; }
    public UIObjectRef Gem { get; set; }
    public UIObjectRef Pendulum { get; set; }
    public UIObjectRef Info { get; set; }
    public List<UIObjectRef> Skills { get; set; }
    public List<UIObjectRef> InfoTexts { get; set; }
    public UIObjectRef Restore { get; set; }
    public UIObjectRef Cancel { get; set; }
    public UIObjectRef FavText { get; set; }
    public UIObjectRef Guide { get; set; }
    public UIObjectRef ItemCount { get; set; }
}

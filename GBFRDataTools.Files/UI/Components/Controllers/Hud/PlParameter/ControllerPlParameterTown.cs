using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.PlParameter;

// ui::component::ControllerPlParameterTown
public class ControllerPlParameterTown : Controller
{
    public UIObjectRef CharaInfo { get; set; }
    public UIObjectRef LevelUp { get; set; }
    public List<UIObjectRef> CharaIcons { get; set; }
    public UIObjectRef CharaPainIcon { get; set; }
    public UIObjectRef RootObject { get; set; }
    public UIObjectRef LeaderIconObject { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef OnlineName { get; set; }
}

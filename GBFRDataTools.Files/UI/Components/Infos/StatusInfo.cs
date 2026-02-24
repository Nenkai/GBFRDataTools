using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::StatusInfo
public class StatusInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Levels { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public List<UIObjectRef> Arrows { get; set; }
    public UIObjectRef Icon { get; set; }
    public List<UIObjectRef> StatusIcons { get; set; }
}

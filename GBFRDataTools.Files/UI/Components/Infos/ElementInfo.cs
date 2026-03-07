using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::ElementInfo
public class ElementInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> InvalidOffs { get; set; }
    public List<UIObjectRef> Images { get; set; }
    public List<UIObjectRef> Texts { get; set; }
}

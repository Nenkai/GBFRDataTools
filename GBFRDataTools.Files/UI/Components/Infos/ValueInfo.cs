using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::ValueInfo
public class ValueInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Values { get; set; }
    public UIObjectRef Arrow { get; set; }
    public UIObjectRef Animator { get; set; }
}

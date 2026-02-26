using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.IconSetters;

// ui::component::ChallengeMissionIconSetter
public class ChallengeMissionIconSetter : IconSetter
{
    public UIObjectRef Icon { get; set; }
    public UIObjectRef IconColor { get; set; }
    public bool Shadow { get; set; }
}

using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::TimeSetter
public class TimeSetter : Component
{
    public UIObjectRef TimeText { get; set; }
    public UIObjectRef Hour { get; set; }
    public UIObjectRef Minute { get; set; }
    public UIObjectRef Second { get; set; }
}

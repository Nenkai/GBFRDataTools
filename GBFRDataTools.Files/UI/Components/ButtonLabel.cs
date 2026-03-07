using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ButtonLabel
public class ButtonLabel : Component
{
    public UIObjectRef Cursor { get; set; }
    public UIObjectRef Button { get; set; }
    public UIObjectRef Text { get; set; }
    public UIObjectRef ImageButton { get; set; }
}

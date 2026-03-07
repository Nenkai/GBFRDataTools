using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::InputTextButton
public class InputTextButton : Component
{
    public UIObjectRef ItemName { get; set; }
    public UIObjectRef OpenShortcut { get; set; }
    public UIObjectRef SoundContainer { get; set; }
    public UIObjectRef Button { get; set; }
}

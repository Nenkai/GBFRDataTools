using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Shortcut
public class Shortcut : Component
{
    public int Logic { get; set; }
    public int ButtonType { get; set; }
    public bool Push { get; set; }
    public bool Always { get; set; }
    public bool Repeat { get; set; }
    public bool Inverse { get; set; }
    public UIObjectRef ItemButton { get; set; }
    public UIObjectRef Button { get; set; }
    public List<int> ButtonTypes { get; set; }
}

using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::OnlineNameColorSetter
public class OnlineNameColorSetter : Component
{
    public int Type { get; set; }
    public List<UIObjectRef> NameTexts { get; set; }
}

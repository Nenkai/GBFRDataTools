using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemNoteViewerSelectButton
public class ItemNoteViewerSelectButton : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public UIObjectRef Icon { get; set; }
}

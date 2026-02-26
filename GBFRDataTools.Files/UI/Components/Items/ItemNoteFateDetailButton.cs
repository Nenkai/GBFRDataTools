using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemNoteFateDetailButton
public class ItemNoteFateDetailButton : Component
{
    public UIObjectRef Animator { get; set; }
    public UIObjectRef ItemOwnerObject { get; set; }
    public UIObjectRef NewIconImage { get; set; }
    public UIObjectRef LockIconImage { get; set; }
    public UIObjectRef FateEpIconImage { get; set; }
    public List<UIObjectRef> TextList { get; set; }
    public UIObjectRef DisableCanvas { get; set; }
    public UIObjectRef FixOwnerObject { get; set; }
    public UIObjectRef CursorOwnerObject { get; set; }
    public UIObjectRef FateEpisodeInfo { get; set; }
    public UIObjectRef HeaderTexts { get; set; }
    public UIObjectRef EpisodeNumberText { get; set; }
}

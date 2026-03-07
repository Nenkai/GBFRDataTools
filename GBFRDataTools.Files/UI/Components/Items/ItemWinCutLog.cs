using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemWinCutLog
public class ItemWinCutLog : Component
{
    public UIObjectRef ItemAnimator { get; set; }
    public UIObjectRef WindowObj { get; set; }
    public UIObjectRef CursorObj { get; set; }
    public List<UIObjectRef> VoiceIcons { get; set; }
    public UIObjectRef Chara { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public UIObjectRef Button { get; set; }
    public UIObjectRef BaseOther { get; set; }
    public UIObjectRef BasePlayer { get; set; }
    public UIObjectRef TextObj { get; set; }
}

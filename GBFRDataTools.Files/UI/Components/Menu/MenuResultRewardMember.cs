using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::MenuResultRewardMember
public class MenuResultRewardMember : Menu
{
    public UIObjectRef Anim { get; set; }
    public UIObjectRef ButtonGuide { get; set; }
    public UIObjectRef VoteButton { get; set; }
    public UIObjectRef MemberActiveOwner { get; set; }
    public UIObjectRef MemberParentObject { get; set; }
    public List<UIObjectRef> ButtonGuideObjList { get; set; }
    public UIObjectRef StatusText { get; set; }
}

using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuResultRewardMember
public class MenuResultRewardMember // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Anim", UIFieldType.ObjectRef),
        new("ButtonGuide", UIFieldType.ObjectRef),
        new("VoteButton", UIFieldType.ObjectRef),
        new("MemberActiveOwner", UIFieldType.ObjectRef),
        new("MemberParentObject", UIFieldType.ObjectRef),
        new("ButtonGuideObjList", UIFieldType.ObjectRefVector),
        new("StatusText", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

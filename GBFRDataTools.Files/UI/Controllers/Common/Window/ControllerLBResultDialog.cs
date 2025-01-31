using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerLBResultDialog
public class ControllerLBResultDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("TitleText", UIFieldType.ObjectRef),
        new("InfoText", UIFieldType.ObjectRef),
        new("ApTitleText", UIFieldType.ObjectRef),
        new("MenuDialog", UIFieldType.ObjectRef),
        new("MenuOverLimit", UIFieldType.ObjectRef),
        new("LbIcon", UIFieldType.ObjectRef),
        new("AbilityIcon", UIFieldType.ObjectRef),
        new("AbilityIconObject", UIFieldType.ObjectRef),
        new("LbIconObject", UIFieldType.ObjectRef),
        new("OverlimitObject", UIFieldType.ObjectRef),
        new("SkilltreeObject", UIFieldType.ObjectRef),
        new("CautionTextObject", UIFieldType.ObjectRef),
        new("EmptyTextObject", UIFieldType.ObjectRef),
        new("ErrorTextObject", UIFieldType.ObjectRef),
        new("BeforeMspText", UIFieldType.ObjectRef),
        new("AfterMspText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

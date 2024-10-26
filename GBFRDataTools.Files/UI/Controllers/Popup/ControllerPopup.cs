using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Popup;

// ui::component::ControllerPopupQuestReadyError
public class ControllerPopup // : ControllerPopupBase
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("InfoText", UIFieldType.ObjectRef),
        new("TitleRoot", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("FixShortcut", UIFieldType.ObjectRef),
        new("ItemCursor", UIFieldType.ObjectRef),
        new("SaveIconRoot", UIFieldType.ObjectRef),
        new("SaveIcon", UIFieldType.ObjectRef),
        new("Disables", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ControllerPopupBase.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

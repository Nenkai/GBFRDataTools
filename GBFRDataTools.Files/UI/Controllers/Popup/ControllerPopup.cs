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
        new("InfoText", FieldType.ObjectRef),
        new("TitleRoot", FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new("FixShortcut", FieldType.ObjectRef),
        new("ItemCursor", FieldType.ObjectRef),
        new("SaveIconRoot", FieldType.ObjectRef),
        new("SaveIcon", FieldType.ObjectRef),
        new("Disables", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ControllerPopupBase.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Popup;

// ui::component::ControllerPopupQuestReadyError
public class ControllerPopupQuestReadyError // : ControllerPopupBase
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Title", FieldType.ObjectRef),
        new("TitleSet", FieldType.ObjectRef),
        new("NgReason", FieldType.ObjectRef),
        new("NgPlayerNames", FieldType.ObjectRefVector),
        new("Fix", FieldType.ObjectRef),
        new("Cursor", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ControllerPopupBase.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

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
        new("Title", UIFieldType.ObjectRef),
        new("TitleSet", UIFieldType.ObjectRef),
        new("NgReason", UIFieldType.ObjectRef),
        new("NgPlayerNames", UIFieldType.ObjectRefVector),
        new("Fix", UIFieldType.ObjectRef),
        new("Cursor", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ControllerPopupBase.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

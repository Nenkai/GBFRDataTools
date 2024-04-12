using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerWinCut
public class ControllerWinCut // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("Root", FieldType.ObjectRef),
        new UIPropertyTypeDef("Name", FieldType.ObjectRef),
        new UIPropertyTypeDef("Text", FieldType.ObjectRef),
        new UIPropertyTypeDef("Auto", FieldType.ObjectRef),
        new UIPropertyTypeDef("Skip", FieldType.ObjectRef),
        new UIPropertyTypeDef("ToLog", FieldType.ObjectRef),
        new UIPropertyTypeDef("ToWord", FieldType.ObjectRef),
        new UIPropertyTypeDef("ToWordText", FieldType.ObjectRef),
        new UIPropertyTypeDef("AutoButton", FieldType.ObjectRef),
        new UIPropertyTypeDef("WordButton", FieldType.ObjectRef),
        new UIPropertyTypeDef("LogButton", FieldType.ObjectRef),
        new UIPropertyTypeDef("Cursor", FieldType.ObjectRef),
        new UIPropertyTypeDef("TextObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("WordObj", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

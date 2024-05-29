using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemSubMission
public class ItemSubMission // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("SubMission", FieldType.ObjectRef),
         new("Icon", FieldType.ObjectRef),
         new("Button", FieldType.ObjectRef),
         new("Stick", FieldType.ObjectRef),
         new("ButtonSetter", FieldType.ObjectRef),
         new("TutorialSound", FieldType.ObjectRef),
         new("Count", FieldType.ObjectRef),
         new("NowCount", FieldType.ObjectRef),
         new("TargetCount", FieldType.ObjectRef),
         new("Num01", FieldType.ObjectRef),
         new("Num03", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

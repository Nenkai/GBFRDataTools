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
         new("SubMission", UIFieldType.ObjectRef),
         new("Icon", UIFieldType.ObjectRef),
         new("Button", UIFieldType.ObjectRef),
         new("Stick", UIFieldType.ObjectRef),
         new("ButtonSetter", UIFieldType.ObjectRef),
         new("TutorialSound", UIFieldType.ObjectRef),
         new("Count", UIFieldType.ObjectRef),
         new("NowCount", UIFieldType.ObjectRef),
         new("TargetCount", UIFieldType.ObjectRef),
         new("Num01", UIFieldType.ObjectRef),
         new("Num03", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

using GBFRDataTools.Files.UI;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ChangeSkillDispMode
public class ChangeSkillDispMode // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Animator", FieldType.ObjectRef),
         new("SoundContainer", FieldType.ObjectRef),
         new(0x99CA5014, FieldType.ObjectRef),
         new(0xC98629F2, FieldType.ObjectRef),
         new("ChangeSkillDispMode", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

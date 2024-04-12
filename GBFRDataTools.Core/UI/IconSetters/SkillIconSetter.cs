using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.IconSetters;

// ui::component::SkillIconSetter
public class SkillIconSetter // : IconSetter
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        return IconSetter.GetAllProperties();
    }
}

using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.IconSetters;

// ui::component::NoteIconSetter
public class NoteIconSetter // : IconSetter
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        return IconSetter.GetAllProperties();
    }
}

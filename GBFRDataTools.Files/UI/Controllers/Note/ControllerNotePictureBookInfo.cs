using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Note;

// ui::component::ControllerNotePictureBookInfo
public class ControllerNotePictureBookInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("TextProfile", UIFieldType.ObjectRefVector),
        new("ProfileObject", UIFieldType.ObjectRefVector),
        new("ProfileLine", UIFieldType.ObjectRefVector),
        new("FilterEmptyActiveObjects", UIFieldType.ObjectRefVector),
        new("FilterEmptyDeactiveObjects", UIFieldType.ObjectRefVector),
        new("UpdateIcons", UIFieldType.ObjectRefVector),
        new("TextName", UIFieldType.ObjectRef),
        new("TextAge", UIFieldType.ObjectRef),
        new("TextHeight", UIFieldType.ObjectRef),
        new("TextRace", UIFieldType.ObjectRef),
        new("TextHobby", UIFieldType.ObjectRef),
        new("TextFavorite", UIFieldType.ObjectRef),
        new("TextWeak", UIFieldType.ObjectRef),
        new(0xF6558AD7, UIFieldType.ObjectRef),
        new("TextInfo", UIFieldType.ObjectRef),
        new("Image", UIFieldType.ObjectRef),
        new("CharaIcon", UIFieldType.ObjectRef),
        new("ScrollBar", UIFieldType.ObjectRef),
        new("ScrollTargetObject", UIFieldType.ObjectRef),
        new("ScrollDispObject", UIFieldType.ObjectRef),
        new("MaterialInfo", UIFieldType.ObjectRef),
        new("WeaponInfo", UIFieldType.ObjectRef),
        new("GemInfo", UIFieldType.ObjectRef),
        new("PendulumInfo", UIFieldType.ObjectRef),
        new("FilterEmptyText", UIFieldType.ObjectRef),
        new("RarityPlate", UIFieldType.ObjectRef),
        new("CountPlate", UIFieldType.ObjectRef),
        new("NowImageCount", UIFieldType.ObjectRef),
        new("MaxImageCount", UIFieldType.ObjectRef),
        new("DispObject", UIFieldType.ObjectRef),
        new("CharaPersonalInfo", UIFieldType.ObjectRef),
        new("WeaponIcon", UIFieldType.ObjectRef),
        new("ElementInfo", UIFieldType.ObjectRef),
        new("FavoriteInfo", UIFieldType.ObjectRef),
        new(0xDB016476, UIFieldType.ObjectRef),
        new("Mode", UIFieldType.S32),

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

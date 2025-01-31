using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Quest.QuestPoint;

// ui::component::ControllerQuestDetail
public class ControllerQuestDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x9C90F0F2, UIFieldType.ObjectRefVector),
        new("EnemyList", UIFieldType.ObjectRefVector),
        new(0x2FE40040, UIFieldType.ObjectRefVector),
        new(0xEFEC3E42, UIFieldType.ObjectRefVector),
        new(0xB0A6E085, UIFieldType.ObjectRefVector),
        new("SubmissionTexts", UIFieldType.ObjectRefVector),
        new(0x4BE537A4, UIFieldType.ObjectRefVector),
        new(0x76F324A1, UIFieldType.ObjectRefVector),
        new(0x8BC0AA03, UIFieldType.ObjectRefVector),
        new("QuestInfo", UIFieldType.ObjectRef),
        new(0x4A397A7A, UIFieldType.ObjectRef),
        new(0xA863427F, UIFieldType.ObjectRef),
        new(0x48232D31, UIFieldType.ObjectRef),
        new("TabMenu", UIFieldType.ObjectRef),
        new("ExpText", UIFieldType.ObjectRef),
        new("RupiText", UIFieldType.ObjectRef),
        new(0x6284ABAD, UIFieldType.ObjectRef),
        new("PrevTabShortcut", UIFieldType.ObjectRef),
        new("NextTabShortcut", UIFieldType.ObjectRef),
        new(0xBFD420DF, UIFieldType.ObjectRef),
        new(0x61C32A6A, UIFieldType.ObjectRef),
        new(0xC69A74DB, UIFieldType.ObjectRef),
        new(0x7CFB30E6, UIFieldType.ObjectRef),
        new(0x95CE50C5, UIFieldType.ObjectRef),
        new(0x17AB390D, UIFieldType.ObjectRef),
        new(0x8F3FDC81, UIFieldType.ObjectRef),
        new(0xE5D62425, UIFieldType.ObjectRef),
        new(0x30B951, UIFieldType.ObjectRef),
        new(0x4599BEA3, UIFieldType.ObjectRef),
        new(0x6AE9ABBF, UIFieldType.ObjectRef),
        new(0x230B8C3E, UIFieldType.ObjectRef),
        new(0x99583C4B, UIFieldType.ObjectRef),
        new(0x9D2A1ECD, UIFieldType.ObjectRef),
        new(0xCEBBF3F6, UIFieldType.ObjectRef),
        new(0xE3FF99A6, UIFieldType.ObjectRef),
        new(0x368CFB3B, UIFieldType.ObjectRef),
        new("FavoriteButton", UIFieldType.ObjectRef),
        new("QuestBtnL", UIFieldType.ObjectRef),
        new("QuestBtnR", UIFieldType.ObjectRef),
        new(0xAA135536, UIFieldType.ObjectRef),
        new(0xE9F9BAC0, UIFieldType.ObjectRef),
        new(0xE4EEDDE7, UIFieldType.ObjectRef),
        new(0xD99AA1A5, UIFieldType.ObjectRef),
        new(0x3C777B7, UIFieldType.ObjectRef),
        new(0x320670D3, UIFieldType.ObjectRef),
        new(0x64E8A274, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::QuestGameCateInfo
public class QuestGameCateInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new(0xC81D7BB3, UIFieldType.ObjectRefVector),
        new(0xF382810, UIFieldType.ObjectRefVector),
        new(0x9A3AD418, UIFieldType.ObjectRefVector),
        new(0x983AB93A, UIFieldType.ObjectRefVector),
        new(0x60C14C46, UIFieldType.ObjectRefVector),
        new(0x659746BD, UIFieldType.ObjectRefVector),
        new("KeyQuestIcons", UIFieldType.ObjectRefVector),
        new("UpdateIcons", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

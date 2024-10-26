using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SoundContainer
public class SoundContainer // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Labels", UIFieldType.StringVector),
        new("PlaybackInFade", UIFieldType.Bool),
        new("Decide", UIFieldType.String),
        new("Decide02", UIFieldType.String),
        new("Decide03", UIFieldType.String),
        new("Sub", UIFieldType.String),
        new("Add", UIFieldType.String),
        new("Error", UIFieldType.String),
        new("Cursor", UIFieldType.String),
        new("Cancel", UIFieldType.String),
        new("WindowOpen", UIFieldType.String),
        new("WindowClose", UIFieldType.String),
        new("Other1", UIFieldType.String),
        new("Other2", UIFieldType.String),
        new("Other3", UIFieldType.String),
        new("Other4", UIFieldType.String),
        new("Other5", UIFieldType.String),
        new("Other6", UIFieldType.String),
        new("CursorUd", UIFieldType.String),
        new("SelectCancel", UIFieldType.String),
        new("TabLr", UIFieldType.String),
        new("CursorLr", UIFieldType.String),
        new("Choice", UIFieldType.String),
        new("Sort", UIFieldType.String),
        new("Remove", UIFieldType.String),
        new("Index", UIFieldType.String),
        new("SelectLock", UIFieldType.String),
        new("Max", UIFieldType.String),
        new(0x691BDEFB, UIFieldType.String),
        new(0x8C106E4D, UIFieldType.String),
        new(0xA033C91A, UIFieldType.String),
        new(0xDA6FFB4E, UIFieldType.String),
        new(0xFBBE3946, UIFieldType.String),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

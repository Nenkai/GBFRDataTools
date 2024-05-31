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
        new("Labels", FieldType.StringVector),
        new("PlaybackInFade", FieldType.Bool),
        new("Decide", FieldType.String),
        new("Decide02", FieldType.String),
        new("Decide03", FieldType.String),
        new("Sub", FieldType.String),
        new("Add", FieldType.String),
        new("Error", FieldType.String),
        new("Cursor", FieldType.String),
        new("Cancel", FieldType.String),
        new("WindowOpen", FieldType.String),
        new("WindowClose", FieldType.String),
        new("Other1", FieldType.String),
        new("Other2", FieldType.String),
        new("Other3", FieldType.String),
        new("Other4", FieldType.String),
        new("Other5", FieldType.String),
        new("Other6", FieldType.String),
        new("CursorUd", FieldType.String),
        new("SelectCancel", FieldType.String),
        new("TabLr", FieldType.String),
        new("CursorLr", FieldType.String),
        new("Choice", FieldType.String),
        new("Sort", FieldType.String),
        new("Remove", FieldType.String),
        new("Index", FieldType.String),
        new("SelectLock", FieldType.String),
        new("Max", FieldType.String),
        new(0x691BDEFB, FieldType.String),
        new(0x8C106E4D, FieldType.String),
        new(0xA033C91A, FieldType.String),
        new(0xDA6FFB4E, FieldType.String),
        new(0xFBBE3946, FieldType.String),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

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
        new(0x7BD8E28E, FieldType.String),
        new("CursorLr", FieldType.String),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

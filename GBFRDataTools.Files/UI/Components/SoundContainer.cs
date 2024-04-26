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
        new UIPropertyTypeDef("Labels", FieldType.StringVector),
        new UIPropertyTypeDef("PlaybackInFade", FieldType.Bool),
        new UIPropertyTypeDef("Decide", FieldType.String),
        new UIPropertyTypeDef("Decide02", FieldType.String),
        new UIPropertyTypeDef("Decide03", FieldType.String),
        new UIPropertyTypeDef("Sub", FieldType.String),
        new UIPropertyTypeDef("Add", FieldType.String),
        new UIPropertyTypeDef("Error", FieldType.String),
        new UIPropertyTypeDef("Cursor", FieldType.String),
        new UIPropertyTypeDef("Cancel", FieldType.String),
        new UIPropertyTypeDef("WindowOpen", FieldType.String),
        new UIPropertyTypeDef("WindowClose", FieldType.String),
        new UIPropertyTypeDef("Other1", FieldType.String),
        new UIPropertyTypeDef("Other2", FieldType.String),
        new UIPropertyTypeDef("Other3", FieldType.String),
        new UIPropertyTypeDef("Other4", FieldType.String),
        new UIPropertyTypeDef("Other5", FieldType.String),
        new UIPropertyTypeDef("Other6", FieldType.String),
        new UIPropertyTypeDef("CursorUd", FieldType.String),
        new UIPropertyTypeDef("SelectCancel", FieldType.String),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

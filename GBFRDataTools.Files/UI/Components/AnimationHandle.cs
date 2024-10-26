using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::AnimationHandle
public class AnimationHandle // : Component
{
    public static readonly List<UIPropertyTypeDef> Properties = 
    [
         new("Offset", UIFieldType.S32),
         new("Handles", UIFieldType.ObjectArray,
         [
             // ui::component::AnimationHandleObj
             new("LayerName", UIFieldType.String),
             new("Clips", UIFieldType.StringVector),
             new("Skip", UIFieldType.Bool),
         ])
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

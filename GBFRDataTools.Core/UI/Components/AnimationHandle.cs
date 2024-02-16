using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::AnimationHandle
public class AnimationHandle // : Component
{
    public static readonly List<UIPropertyTypeDef> Properties = 
    [
         new UIPropertyTypeDef("Offset", FieldType.S32),
         new UIPropertyTypeDef("Handles", FieldType.ObjectArray,
         [
             // ui::component::AnimationHandleObj
             new UIPropertyTypeDef("LayerName", FieldType.String),
             new UIPropertyTypeDef("Clips", FieldType.StringVector),
             new UIPropertyTypeDef("Skip", FieldType.Bool),
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

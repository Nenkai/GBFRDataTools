using GBFRDataTools.Files.UI;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Animator
public class Animator // : Component
{
    public static readonly List<UIPropertyTypeDef> Properties =
    [
         new UIPropertyTypeDef("Base", FieldType.Object, 
         [
             // ui::animation::Custom
             new UIPropertyTypeDef("Indexes", FieldType.S32Vector),
             new UIPropertyTypeDef("Layer", FieldType.String),
         ]),

        new UIPropertyTypeDef("Change", FieldType.Object,
        [
            // ui::animation::Custom
            new UIPropertyTypeDef("Indexes", FieldType.S32Vector),
            new UIPropertyTypeDef("Layer", FieldType.String),
        ]),

        new UIPropertyTypeDef("Layers", FieldType.ObjectArray, new()
         {
             // ui::animation::Layer
             new UIPropertyTypeDef("Defaults", FieldType.S32Vector),
             new UIPropertyTypeDef("States", FieldType.ObjectArray, new()
             {
                 // ui::animation::State
                 new UIPropertyTypeDef("AnimationPath", FieldType.String),
                 new UIPropertyTypeDef("WriteDefault", FieldType.Bool),
             }),
             new UIPropertyTypeDef("Name", FieldType.String)
         }),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

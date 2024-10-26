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
         new("Base", UIFieldType.Object, 
         [
             // ui::animation::Custom
             new("Layer", UIFieldType.String),
             new("Indexes", UIFieldType.S32Vector),
         ]),

        new("Change", UIFieldType.Object,
        [
            // ui::animation::Custom
            new("Indexes", UIFieldType.S32Vector),
            new("Layer", UIFieldType.String),
        ]),

        new("Layers", UIFieldType.ObjectArray, new()
         {
             // ui::animation::Layer
             new("Name", UIFieldType.String),
             new("Defaults", UIFieldType.S32Vector),
             new("States", UIFieldType.ObjectArray, new()
             {
                 // ui::animation::State
                 new("WriteDefault", UIFieldType.Bool),
                 new("AnimationPath", UIFieldType.String),
             }),
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

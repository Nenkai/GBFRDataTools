using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.GuideCommand;

// ui::component::ControllerGuideCommand
public class ControllerGuideCommand // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("SmallIcons", UIFieldType.ObjectRefVector),
        new("BigIcons", UIFieldType.ObjectRefVector),
        new("EffectIcons", UIFieldType.ObjectRefVector),
        new("R1", UIFieldType.ObjectRef),
        new("Root", UIFieldType.ObjectRef),
        new("AttackNames", UIFieldType.ObjectRefVector),
        new("SpAttackNames", UIFieldType.ObjectRefVector),
        new("AbilityArea", UIFieldType.ObjectRef),
        new("AbilityGuide", UIFieldType.ObjectRef),
        new("LinkAttackText", UIFieldType.ObjectRef),
        new("LinkAttackCommand", UIFieldType.ObjectRef),
        new("LinkAttackButton", UIFieldType.ObjectRef),
        new("LinkAttackButtonShortcut", UIFieldType.ObjectRef),
        new("SpAttackCommand", UIFieldType.ObjectRef),
        new("SpAttackButton", UIFieldType.ObjectRef),
        new("HighlightR1", UIFieldType.ObjectRef),
        new("HighlightAbilitys", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

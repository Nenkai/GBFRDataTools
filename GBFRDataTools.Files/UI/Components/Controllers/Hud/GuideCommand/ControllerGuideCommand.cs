using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GuideCommand;

// ui::component::ControllerGuideCommand
public class ControllerGuideCommand : Controller
{
    public List<UIObjectRef> SmallIcons { get; set; }
    public List<UIObjectRef> BigIcons { get; set; }
    public List<UIObjectRef> EffectIcons { get; set; }
    public UIObjectRef R1 { get; set; }
    public UIObjectRef Root { get; set; }
    public List<UIObjectRef> AttackNames { get; set; }
    public List<UIObjectRef> SpAttackNames { get; set; }
    public UIObjectRef AbilityArea { get; set; }
    public UIObjectRef AbilityGuide { get; set; }
    public UIObjectRef LinkAttackText { get; set; }
    public UIObjectRef LinkAttackCommand { get; set; }
    public UIObjectRef LinkAttackButton { get; set; }
    public UIObjectRef LinkAttackButtonShortcut { get; set; }
    public UIObjectRef SpAttackCommand { get; set; }
    public UIObjectRef SpAttackButton { get; set; }
    public UIObjectRef HighlightR1 { get; set; }
    public List<UIObjectRef> HighlightAbilitys { get; set; }
}

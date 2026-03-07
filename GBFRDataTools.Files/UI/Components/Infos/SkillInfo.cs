using GBFRDataTools.Files.UI.Types;

using System.Numerics;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::SkillInfo
public class SkillInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Hides { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> Levels { get; set; }
    public List<UIObjectRef> Labels { get; set; }
    public List<UIObjectRef> PlusImages { get; set; }
    public List<UIObjectRef> PlusImageSetter { get; set; }
    public UIObjectRef Plus { get; set; }
    public UIObjectRef Canvas { get; set; }
    public bool ChangeColorDisable { get; set; }
    public bool ChangeGemColorDisable { get; set; }
    public List<UIObjectRef> SlvUnit { get; set; }
    public List<UIObjectRef> Pendulums { get; set; }
    public UIObjectRef PendulumBlurImageColor { get; set; }
    public UIObjectRef PendulumBaseImageColor { get; set; }
    public UIObjectRef Tag { get; set; }
    public int TextColorType { get; set; }
    public Vector4 TextCustomColor { get; set; }
    public Vector4 TextSelectCustomColor { get; set; }
    public int SlvColorChangeType { get; set; }
    public UIObjectRef LabelDefault { get; set; }
    public UIObjectRef LabelNew { get; set; }
    public UIObjectRef SlvDefault { get; set; }
    public UIObjectRef SlvUp { get; set; }
    public UIObjectRef SlvDown { get; set; }
    public List<UIObjectRef> BeforeObjs { get; set; }
    public List<UIObjectRef> AfterObjs { get; set; }
    public List<UIObjectRef> AfterIcons { get; set; }
    public int GeenContainerNo { get; set; }
    public UIObjectRef SummaryText { get; set; }
    public List<UIObjectRef> Frames { get; set; }
    public UIObjectRef Highlight { get; set; }
    public UIObjectRef FrameAnimator { get; set; }
}

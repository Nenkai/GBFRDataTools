using GBFRDataTools.Files.UI.Types;

using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ChangeSkillDispMode
public class ChangeSkillDispMode : Component
{
    public UIObjectRef Animator { get; set; }
    public UIObjectRef SoundContainer { get; set; }
    public UIObjectRef _99CA5014 { get; set; }
    public UIObjectRef GuideText { get; set; }

    [YamlMember(Alias = "ChangeSkillDispMode")]
    public UIObjectRef ChangeSkillDispMode_ { get; set; }
}

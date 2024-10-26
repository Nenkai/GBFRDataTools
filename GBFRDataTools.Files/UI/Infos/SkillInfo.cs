using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::SkillInfo
public class SkillInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
        new("Icons", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector),
        new("Levels", UIFieldType.ObjectRefVector),
        new("Labels", UIFieldType.ObjectRefVector),
        new("PlusImages", UIFieldType.ObjectRefVector),
        new("PlusImageSetter", UIFieldType.ObjectRefVector),
        new("Plus", UIFieldType.ObjectRef),
        new("Canvas", UIFieldType.ObjectRef),
        new("ChangeColorDisable", UIFieldType.Bool),
        new("ChangeGemColorDisable", UIFieldType.Bool),
        new("SlvUnit", UIFieldType.ObjectRefVector),
        new("Pendulums", UIFieldType.ObjectRefVector),
        new("PendulumBlurImageColor", UIFieldType.ObjectRef),
        new("PendulumBaseImageColor", UIFieldType.ObjectRef),
        new("Tag", UIFieldType.ObjectRef),
        new("TextColorType", UIFieldType.S32),
        new("TextCustomColor", UIFieldType.CVec4),
        new("TextSelectCustomColor", UIFieldType.CVec4),
        new("SlvColorChangeType", UIFieldType.S32),
        new("LabelDefault", UIFieldType.ObjectRef),
        new("LabelNew", UIFieldType.ObjectRef),
        new("SlvDefault", UIFieldType.ObjectRef),
        new("SlvUp", UIFieldType.ObjectRef),
        new("SlvDown", UIFieldType.ObjectRef),
        new("BeforeObjs", UIFieldType.ObjectRefVector),
        new("AfterObjs", UIFieldType.ObjectRefVector),
        new("AfterIcons", UIFieldType.ObjectRefVector),
        new("GeenContainerNo", UIFieldType.S32),
        new("SummaryText", UIFieldType.ObjectRef),
        new("Frames", UIFieldType.ObjectRefVector),
        new("Highlight", UIFieldType.ObjectRef),
        new("FrameAnimator", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

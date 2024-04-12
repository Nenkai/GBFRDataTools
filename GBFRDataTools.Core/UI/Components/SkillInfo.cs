using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SkillInfo
public class SkillInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Sets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Hides", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Icons", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Names", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Levels", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Labels", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("PlusImages", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("PlusImageSetter", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Plus", FieldType.ObjectRef),
        new UIPropertyTypeDef("Canvas", FieldType.ObjectRef),
        new UIPropertyTypeDef("ChangeColorDisable", FieldType.Bool),
        new UIPropertyTypeDef("ChangeGemColorDisable", FieldType.Bool),
        new UIPropertyTypeDef("SlvUnit", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Pendulums", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("PendulumBlurImageColor", FieldType.ObjectRef),
        new UIPropertyTypeDef("PendulumBaseImageColor", FieldType.ObjectRef),
        new UIPropertyTypeDef("Tag", FieldType.ObjectRef),
        new UIPropertyTypeDef("TextColorType", FieldType.S32),
        new UIPropertyTypeDef("TextCustomColor", FieldType.CVec4),
        new UIPropertyTypeDef("TextSelectCustomColor", FieldType.CVec4),
        new UIPropertyTypeDef("SlvColorChangeType", FieldType.S32),
        new UIPropertyTypeDef("LabelDefault", FieldType.ObjectRef),
        new UIPropertyTypeDef("LabelNew", FieldType.ObjectRef),
        new UIPropertyTypeDef("SlvDefault", FieldType.ObjectRef),
        new UIPropertyTypeDef("SlvUp", FieldType.ObjectRef),
        new UIPropertyTypeDef("SlvDown", FieldType.ObjectRef),
        new UIPropertyTypeDef("BeforeObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("AfterObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("AfterIcons", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("GeenContainerNo", FieldType.S32),
        new UIPropertyTypeDef("SummaryText", FieldType.ObjectRef),
        new UIPropertyTypeDef("Frames", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Highlight", FieldType.ObjectRef),
        new UIPropertyTypeDef("FrameAnimator", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}

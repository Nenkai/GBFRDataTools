using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Files.UI;
using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Files.UI.IconSetters;
using GBFRDataTools.Files.UI.LayoutGroups;
using GBFRDataTools.Files.UI.Menu;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.Files.UI;

public class KnownProperties
{
    public static Dictionary<string, List<UIPropertyTypeDef>> ComponentList = new()
    {
        { "AnimationHandle", AnimationHandle.GetAllProperties() },
        { "Animator", Animator.GetAllProperties() },
        { "Button", Button.GetAllProperties() },
        { "ButtonGuide", ButtonGuide.GetAllProperties() },
        { "CanvasGroup", CanvasGroup.GetAllProperties() },
        { "CharaIconSetter", CharaIconSetter.GetAllProperties() },
        { "CharaInfo", CharaInfo.GetAllProperties() },
        { "ContentSizeFitter", ContentSizeFitter.GetAllProperties() },
        { "ControllerApTreeBg", ControllerApTreeBg.GetAllProperties() },
        { "ControllerBg", ControllerBg.GetAllProperties() },
        { "ControllerDialog", ControllerDialog.GetAllProperties() },
        { "ControllerDataSave", ControllerDataSave.GetAllProperties() },
        { "ControllerGeenDetail", ControllerGeenDetail.GetAllProperties() },
        { "ControllerInventoryInfo", ControllerInventoryInfo.GetAllProperties() },
        { "ControllerPendulumDetail", ControllerPendulumDetail.GetAllProperties() },
        { "ControllerSaveCaution", ControllerSaveCaution.GetAllProperties() },
        { "ControllerTitleTop", ControllerTitleTop.GetAllProperties() },
        { "ControllerWinCut", ControllerWinCut.GetAllProperties() },
        { "Dissolve", Dissolve.GetAllProperties() },
        { "Gauss", Gauss.GetAllProperties() },
        { "GaugeMask", GaugeMask.GetAllProperties() },
        { "GemInfo", GemInfo.GetAllProperties() },
        { "GemIconSetter", GemIconSetter.GetAllProperties() },
        { "GemEffectInfo", GemEffectInfo.GetAllProperties() },
        { "GemIconEffectSetter", GemIconEffectSetter.GetAllProperties() },
        { "HorizontalLayoutGroup", HorizontalLayoutGroup.GetAllProperties() },
        { "Highlight", Highlight.GetAllProperties() },
        { "IconSetter", IconSetter.GetAllProperties() },
        { "ItemIconSetter", ItemIconSetter.GetAllProperties() },
        { "Image", Image.GetAllProperties() },
        { "ImageButtonSetter", ImageButtonSetter.GetAllProperties() },
        { "ImageMultiSetter", ImageMultiSetter.GetAllProperties() },
        { "ImageSetter", ImageSetter.GetAllProperties() },
        { "ItemButton", ItemButton.GetAllProperties() },
        { "ItemButtonText", ItemButtonText.GetAllProperties() },
        { "ItemCursor", ItemCursor.GetAllProperties() },
        { "ItemLevel", ItemLevel.GetAllProperties() },
        { "LanguageSetter", LanguageSetter.GetAllProperties() },
        { "LayoutElement", LayoutElement.GetAllProperties() },
        { "Mask", Mask.GetAllProperties() },
        { "MenuDialog", MenuDialog.GetAllProperties() },
        { "MenuPressAny", MenuPressAny.GetAllProperties() },
        { "Movie", Movie.GetAllProperties() },
        { "NumSetter", NumSetter.GetAllProperties() },
        { "PendulumInfo", PendulumInfo.GetAllProperties() },
        { "ScrollBar", ScrollBar.GetAllProperties() },
        { "Shortcut", Shortcut.GetAllProperties() },
        { "SkillIconSetter", SkillIconSetter.GetAllProperties() },
        { "SkillInfo", SkillInfo.GetAllProperties() },
        { "SoundContainer", SoundContainer.GetAllProperties() },
        { "Text", Text.GetAllProperties() },
        { "TextRuby", TextRuby.GetAllProperties() },
        { "TextSetter", TextSetter.GetAllProperties() },
        { "ValueInfo", ValueInfo.GetAllProperties() },
        { "VerticalLayoutGroup", VerticalLayoutGroup.GetAllProperties() },
        { "WeaponIconSetter", WeaponIconSetter.GetAllProperties() },

    };

    public static List<UIPropertyTypeDef> List { get; set; } =
    [
        // prfb
        new UIPropertyTypeDef("Objects", FieldType.ObjectArray,
        [
            new UIPropertyTypeDef("Name", FieldType.String),
            // ui::component::Object
            new UIPropertyTypeDef("Position", FieldType.CVec3),
            new UIPropertyTypeDef("Rotation", FieldType.CVec4),
            new UIPropertyTypeDef("Scale", FieldType.CVec3),
            new UIPropertyTypeDef("Pivot", FieldType.CVec2),
            new UIPropertyTypeDef("AnchorPoint", FieldType.CVec2),
            new UIPropertyTypeDef("AnchorMin", FieldType.CVec2),
            new UIPropertyTypeDef("AnchorMax", FieldType.CVec2),
            new UIPropertyTypeDef("OffsetMin", FieldType.CVec2),
            new UIPropertyTypeDef("OffsetMax", FieldType.CVec2),
            new UIPropertyTypeDef("SizeDelta", FieldType.CVec2),
            new UIPropertyTypeDef("Active", FieldType.Bool),
            new UIPropertyTypeDef("Id", FieldType.S32),

            // Not part of it?
            new UIPropertyTypeDef("Children", FieldType.S32Vector),
            new UIPropertyTypeDef("Components", FieldType.ObjectArray,
            [
                new UIPropertyTypeDef("ComponentName", FieldType.String),
                new UIPropertyTypeDef("Component", FieldType.Object, []),
            ])
        ]),

        // texb
        new UIPropertyTypeDef("Filter", FieldType.Bool),
        new UIPropertyTypeDef("Wrap", FieldType.Bool),
        new UIPropertyTypeDef("Size", FieldType.CVec2),
        new UIPropertyTypeDef("Sprites", FieldType.ObjectArray,
        [
            new UIPropertyTypeDef("MinSize", FieldType.CVec2),
            new UIPropertyTypeDef("Rect", FieldType.CVec4),
            new UIPropertyTypeDef("Name", FieldType.String),
            new UIPropertyTypeDef("Padding", FieldType.CVec4),
            new UIPropertyTypeDef("Uv", FieldType.CVec4),
            new UIPropertyTypeDef("Border", FieldType.CVec4),
        ]),

        // listb
        new UIPropertyTypeDef("Materials", FieldType.StringVector),
        new UIPropertyTypeDef("Animations", FieldType.StringVector),
        new UIPropertyTypeDef("AtlasData", FieldType.Object,
        [
            new UIPropertyTypeDef("Ita", FieldType.StringVector),
            new UIPropertyTypeDef("Common", FieldType.StringVector),
            new UIPropertyTypeDef("Eng", FieldType.StringVector),
            new UIPropertyTypeDef("Kor", FieldType.StringVector),
            new UIPropertyTypeDef("Cht", FieldType.StringVector),
            new UIPropertyTypeDef("Esp", FieldType.StringVector),
            new UIPropertyTypeDef("Deu", FieldType.StringVector),
            new UIPropertyTypeDef("Fra", FieldType.StringVector),
            new UIPropertyTypeDef("Chs", FieldType.StringVector),
            new UIPropertyTypeDef("Por", FieldType.StringVector),
            new UIPropertyTypeDef("Jpn", FieldType.StringVector),
        ]),
        new UIPropertyTypeDef(0x9029CEE4, FieldType.StringVector),
        new UIPropertyTypeDef("TextureData", FieldType.Object,
        [

        ]),
        new UIPropertyTypeDef("LanguageData", FieldType.StringVector),
        new UIPropertyTypeDef("ImageData", FieldType.StringVector),

        // viewb
        new UIPropertyTypeDef("Layouts", FieldType.ObjectArray,
        [
            new UIPropertyTypeDef("Scale", FieldType.CVec3),
            new UIPropertyTypeDef("AnchorMin", FieldType.CVec2),
            new UIPropertyTypeDef("AssetPath", FieldType.String),
            new UIPropertyTypeDef("OffsetMax", FieldType.CVec2),
            new UIPropertyTypeDef("OffsetMin", FieldType.CVec2),
            new UIPropertyTypeDef("Rotation", FieldType.CVec4),
            new UIPropertyTypeDef("SizeDelta", FieldType.CVec2),
            new UIPropertyTypeDef("Active", FieldType.Bool),
            new UIPropertyTypeDef("Pivot", FieldType.CVec2),
            new UIPropertyTypeDef("AnchorMax", FieldType.CVec2),
            new UIPropertyTypeDef("AnchorPoint", FieldType.CVec2),
        ]),

    ];
}

using GBFRDataTools.Files.UI.Types;

using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::FixedPhraseInfo
public class FixedPhraseInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> TitleTexts { get; set; }
    public List<UIObjectRef> FixedPhraseTexts { get; set; }
    public List<UIObjectRef> EnableObjs { get; set; }

    [YamlMember(Alias = "FixedPhraseInfo")]
    public UIObjectRef FixedPhraseInfo_ { get; set; }

    public UIObjectRef Texts { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef IconImage { get; set; }
    public UIObjectRef Icon { get; set; }
    public List<UIObjectRef> EmotionDataSets { get; set; }
    public List<UIObjectRef> ShortcutSelectObjs { get; set; }
    public List<UIObjectRef> ShortcutSelecttexts { get; set; }
}

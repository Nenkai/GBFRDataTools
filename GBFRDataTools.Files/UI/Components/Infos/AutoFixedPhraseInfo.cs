using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::AutoFixedPhraseInfo
public class AutoFixedPhraseInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> TitleTexts { get; set; }
    public List<UIObjectRef> FixedPhraseTexts { get; set; }
    public List<UIObjectRef> EnableObjs { get; set; }

    public UIObjectRef FixedPhraseInfo { get; set; }
}

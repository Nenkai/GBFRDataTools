using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::EpisodeDifficultyInfo
public class EpisodeDifficultyInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef Clear { get; set; }
}

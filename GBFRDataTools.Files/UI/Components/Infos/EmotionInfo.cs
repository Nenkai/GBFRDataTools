using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::EmotionInfo
public class EmotionInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public List<UIObjectRef> ShortcutSelectObjs { get; set; }
    public List<UIObjectRef> ShortcutSelecttexts { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef IconImage { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
}

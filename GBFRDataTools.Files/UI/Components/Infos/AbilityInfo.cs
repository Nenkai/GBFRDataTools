using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::AbilityInfo
public class AbilityInfo : Component
{
    public List<UIObjectRef> Sets { get; set; } // D0A7B41
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Names { get; set; } // A8C20CB5
    public List<UIObjectRef> Types { get; set; }
    public List<UIObjectRef> Status { get; set; }
    public List<UIObjectRef> Buttons { get; set; }
    public List<UIObjectRef> Elements { get; set; } // 1C864810
    public List<UIObjectRef> _F7B5F034 { get; set; }

    public UIObjectRef Icon { get; set; } // F2856FD4
    public UIObjectRef Frame { get; set; } // B1073935
    public UIObjectRef UpdateIcon { get; set; } // CFFD7733
    public UIObjectRef _4053E19C { get; set; }    
    public UIObjectRef Movie  { get; set; } // C987BAD6
    public UIObjectRef Info { get; set; } // 53380230
    public UIObjectRef Selector { get; set; } // E36BB4D7
}

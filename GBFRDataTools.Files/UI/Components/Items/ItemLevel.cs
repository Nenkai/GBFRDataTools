using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemLevel
public class ItemLevel : Component
{
    public UIObjectRef Level { get; set; }
    public UIObjectRef LevelMaxNum { get; set; }
    public UIObjectRef LevelMaxNumObj { get; set; }
    public UIObjectRef LevelMax { get; set; }
    public UIObjectRef ExpObj { get; set; }
    public UIObjectRef Exp { get; set; }
    public UIObjectRef Gauge { get; set; }
    public UIObjectRef GaugeImg { get; set; }
    public bool HideExp { get; set; }
}

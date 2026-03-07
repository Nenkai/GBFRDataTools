using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::GachaFeverInfo
public class GachaFeverInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> ExecuteCounts { get; set; }
    public List<UIObjectRef> NextCounts { get; set; }
    public UIObjectRef ExecuteCountMax { get; set; }
    public UIObjectRef Gauge { get; set; }
    public UIObjectRef _26EB6D24 { get; set; }
    public UIObjectRef _6EF2AC4A { get; set; }
    public UIObjectRef CompareExecuteCount { get; set; }
    public UIObjectRef CompareGauge { get; set; }
    public UIObjectRef CompareNextCount { get; set; }
}

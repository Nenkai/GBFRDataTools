using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::GachaInfo
public class GachaInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> TicketCounts { get; set; }
    public List<UIObjectRef> FeverConsumeCounts { get; set; }
    public List<UIObjectRef> GeenRarityList { get; set; }
    public List<UIObjectRef> Pendulums { get; set; }
    public List<UIObjectRef> Fevers { get; set; }
    public List<UIObjectRef> FeverObjs { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
}

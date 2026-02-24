using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::ApInfo
public class ApInfo : Component
{
    public List<UIObjectRef> Deactives { get; set; }
    public List<UIObjectRef> IdealCovers { get; set; }
    public List<UIObjectRef> IconSubs { get; set; }
    public List<UIObjectRef> _05558DE7 { get; set; }
    public List<UIObjectRef> UnopenedMats { get; set; }

    public UIObjectRef RootObj { get; set; }
    public UIObjectRef RootWeaponObj { get; set; }
    public UIObjectRef RootIconObj { get; set; }
    public UIObjectRef LbIcon { get; set; }
    public UIObjectRef AbilityIcon { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef Blank { get; set; }
    public UIObjectRef Acquisition { get; set; }
    public UIObjectRef Releasable { get; set; }
    public UIObjectRef IconSub { get; set; }
    public UIObjectRef _F1465DD4 { get; set; }
    public UIObjectRef Frame { get; set; }
    public UIObjectRef EffectMaskImage { get; set; }
}

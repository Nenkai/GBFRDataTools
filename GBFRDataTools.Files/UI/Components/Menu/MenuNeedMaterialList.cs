using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::MenuNeedMaterialList
public class MenuNeedMaterialList : Menu
{
    public int Mode { get; set; }
    public UIObjectRef Left { get; set; }
    public UIObjectRef Right { get; set; }
    public UIObjectRef RupiInfo { get; set; }
    public UIObjectRef Weapon { get; set; }
    public UIObjectRef Chara { get; set; }
    public UIObjectRef Geen { get; set; }
    public UIObjectRef Trade { get; set; }
    public UIObjectRef Exp { get; set; }
    public UIObjectRef Lb { get; set; }
    public UIObjectRef LbLine { get; set; }
    public UIObjectRef PreGetLBInfoRoot { get; set; }
    public bool ViewInvalid { get; set; }
    public List<UIObjectRef> ConditionActive { get; set; }
    public List<UIObjectRef> ConditionInactive { get; set; }
    public List<UIObjectRef> Dials { get; set; }
    public UIObjectRef WarningObj { get; set; }
    public UIObjectRef ConditionText { get; set; }
    public UIObjectRef GuideCheckMaterial { get; set; }
    public UIObjectRef MspInfo { get; set; }
}

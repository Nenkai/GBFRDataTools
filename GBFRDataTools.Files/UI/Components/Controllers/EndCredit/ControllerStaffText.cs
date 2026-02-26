using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.EndCredit;

// ui::component::ControllerStaffText
public class ControllerStaffText : ControllerStaffBase
{
    public List<UIObjectRef> Colums { get; set; }
    public List<UIObjectRef> OneName { get; set; }
    public List<UIObjectRef> TwoNames { get; set; }
    public List<UIObjectRef> ThreeNames { get; set; }
    public List<UIObjectRef> FourNames { get; set; }
    public List<UIObjectRef> FiveNames { get; set; }
    //new("FiveNames", FieldType.ObjectRefVector), for some reason this is duped on their end lol.
}

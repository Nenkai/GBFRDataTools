using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::NeedMaterialInfo
public class NeedMaterialInfo : Component
{
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef Value { get; set; }
    public UIObjectRef Need { get; set; }
    public UIObjectRef NewValue { get; set; }
    public UIObjectRef ExplainText { get; set; }
    public UIObjectRef CanvasGroup { get; set; }
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Hides { get; set; }
    public List<UIObjectRef> SetImages { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public List<UIObjectRef> Lacks { get; set; }
    public List<UIObjectRef> FavLacks { get; set; }
    public List<UIObjectRef> Disables { get; set; }
    public List<UIObjectRef> ShopDisables { get; set; }
    public List<UIObjectRef> DisableImages { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> Values { get; set; }
    public List<UIObjectRef> Needs { get; set; }
    public List<UIObjectRef> NewValues { get; set; }
    public UIObjectRef BgIcon { get; set; }
    public UIObjectRef BgImageSetter { get; set; }
    public UIObjectRef Favorite { get; set; }
}

using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Note;

// ui::component::ControllerNotePictureBookInfo
public class ControllerNotePictureBookInfo : Controller
{
    public List<UIObjectRef> TextProfile { get; set; }
    public List<UIObjectRef> ProfileObject { get; set; }
    public List<UIObjectRef> ProfileLine { get; set; }
    public List<UIObjectRef> FilterEmptyActiveObjects { get; set; }
    public List<UIObjectRef> FilterEmptyDeactiveObjects { get; set; }
    public List<UIObjectRef> UpdateIcons { get; set; }
    public UIObjectRef TextName { get; set; }
    public UIObjectRef TextAge { get; set; }
    public UIObjectRef TextHeight { get; set; }
    public UIObjectRef TextRace { get; set; }
    public UIObjectRef TextHobby { get; set; }
    public UIObjectRef TextFavorite { get; set; }
    public UIObjectRef TextWeak { get; set; }
    public UIObjectRef _F6558AD7 { get; set; }
    public UIObjectRef TextInfo { get; set; }
    public UIObjectRef Image { get; set; }
    public UIObjectRef CharaIcon { get; set; }
    public UIObjectRef ScrollBar { get; set; }
    public UIObjectRef ScrollTargetObject { get; set; }
    public UIObjectRef ScrollDispObject { get; set; }
    public UIObjectRef MaterialInfo { get; set; }
    public UIObjectRef WeaponInfo { get; set; }
    public UIObjectRef GemInfo { get; set; }
    public UIObjectRef PendulumInfo { get; set; }
    public UIObjectRef FilterEmptyText { get; set; }
    public UIObjectRef RarityPlate { get; set; }
    public UIObjectRef CountPlate { get; set; }
    public UIObjectRef NowImageCount { get; set; }
    public UIObjectRef MaxImageCount { get; set; }
    public UIObjectRef DispObject { get; set; }
    public UIObjectRef CharaPersonalInfo { get; set; }
    public UIObjectRef WeaponIcon { get; set; }
    public UIObjectRef ElementInfo { get; set; }
    public UIObjectRef FavoriteInfo { get; set; }
    public UIObjectRef _DB016476 { get; set; }
    public int Mode { get; set; }
}

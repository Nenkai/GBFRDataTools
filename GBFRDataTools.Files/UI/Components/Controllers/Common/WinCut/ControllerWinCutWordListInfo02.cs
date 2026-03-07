using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.WinCut;

// ui::component::ControllerWinCutWordListInfo02
public class ControllerWinCutWordListInfo02 : Controller
{
    public UIObjectRef TextObj { get; set; }
    public UIObjectRef TextBase { get; set; }
    public UIObjectRef TitleText { get; set; }
    public UIObjectRef ArticleText { get; set; }
    public List<UIObjectRef> AddArticleTexts { get; set; }
    public List<UIObjectRef> AddArticleObj { get; set; }
    public List<UIObjectRef> ImageObjects { get; set; }
    public List<UIObjectRef> Images { get; set; }
    public UIObjectRef ScrollBg { get; set; }
    public UIObjectRef ScrollTargetObject { get; set; }
    public UIObjectRef ScrollDispObject { get; set; }
    public UIObjectRef ScrollBar { get; set; }
    public List<UIObjectRef> DecoLines { get; set; }
    public List<UIObjectRef> UpdateIcons { get; set; }
}

using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.WinCut;

// ui::component::ControllerWinCutWordListInfo02
public class ControllerWinCutWordListInfo02 // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("TextObj", UIFieldType.ObjectRef),
        new("TextBase", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("ArticleText", UIFieldType.ObjectRef),
        new("AddArticleTexts", UIFieldType.ObjectRefVector),
        new("AddArticleObj", UIFieldType.ObjectRefVector),
        new("ImageObjects", UIFieldType.ObjectRefVector),
        new("Images", UIFieldType.ObjectRefVector),
        new("ScrollBg", UIFieldType.ObjectRef),
        new("ScrollTargetObject", UIFieldType.ObjectRef),
        new("ScrollDispObject", UIFieldType.ObjectRef),
        new("ScrollBar", UIFieldType.ObjectRef),
        new("DecoLines", UIFieldType.ObjectRefVector),
        new("UpdateIcons", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

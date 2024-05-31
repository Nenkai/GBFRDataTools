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
        new("TextObj", FieldType.ObjectRef),
        new("TextBase", FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new("ArticleText", FieldType.ObjectRef),
        new("AddArticleTexts", FieldType.ObjectRefVector),
        new("AddArticleObj", FieldType.ObjectRefVector),
        new("ImageObjects", FieldType.ObjectRefVector),
        new("Images", FieldType.ObjectRefVector),
        new("ScrollBg", FieldType.ObjectRef),
        new("ScrollTargetObject", FieldType.ObjectRef),
        new("ScrollDispObject", FieldType.ObjectRef),
        new("ScrollBar", FieldType.ObjectRef),
        new("DecoLines", FieldType.ObjectRefVector),
        new("UpdateIcons", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

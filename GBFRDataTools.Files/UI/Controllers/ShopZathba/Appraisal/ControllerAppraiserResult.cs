using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.ShopZathba.Appraisal;

// ui::component::ControllerAppraiserResult
public class ControllerAppraiserResult // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("MenuRewards", UIFieldType.ObjectRef),
        new("RewardInfoItem", UIFieldType.ObjectRef),
        new("RewardInfoGem", UIFieldType.ObjectRef),
        new("RewardInfoPendulum", UIFieldType.ObjectRef),
        new("EmptyRewardText", UIFieldType.ObjectRef),
        new("RewardTitleText", UIFieldType.ObjectRef),
        new("RewardTitleLineBG", UIFieldType.ObjectRef),
        new("FavoriteButton", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}

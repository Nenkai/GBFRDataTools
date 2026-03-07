using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Item;

public class IsExistFavoriteItemAny : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsExistFavoriteItemAny);

    public IsExistFavoriteItemAny()
    {
    }
}

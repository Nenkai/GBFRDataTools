using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.UI.Operations;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ResetShopCursor : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResetShopCursor);
}

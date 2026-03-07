using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Item;

public class CanAwakenWeaponAny : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CanAwakenWeaponAny);

    public CanAwakenWeaponAny()
    {
    }
}

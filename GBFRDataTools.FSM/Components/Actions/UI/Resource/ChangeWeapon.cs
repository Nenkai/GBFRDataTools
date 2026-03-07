using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Resource;

public class ChangeWeapon : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeWeapon);

    public ChangeWeapon()
    {
    }
}

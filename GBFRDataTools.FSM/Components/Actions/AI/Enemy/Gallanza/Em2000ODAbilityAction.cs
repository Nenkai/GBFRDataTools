using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000ODAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000ODAbilityAction);

    public Em2000ODAbilityAction()
    {
    }
}

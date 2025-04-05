using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotTerminateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotTerminateAction);
}

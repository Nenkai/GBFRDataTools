using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0805ShotParentNotifyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0805ShotParentNotifyAction);

    [JsonPropertyName("notify_")]
    public int Notify { get; set; } = 0;
}

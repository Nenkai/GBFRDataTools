using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Elusious;

public class Em1804ShotParentNotifyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1804ShotParentNotifyAction);

    [JsonPropertyName("notify_")]
    public int Notify { get; set; } = 0;
}

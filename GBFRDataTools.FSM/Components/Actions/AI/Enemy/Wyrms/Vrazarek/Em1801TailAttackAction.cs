using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801MagmaEruptionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801MagmaEruptionAction);

    [JsonPropertyName("isSingleTarget_")]
    public bool IsSingleTarget { get; set; } = true; 

    [JsonPropertyName("eruptionNum_")]
    public int EruptionNum { get; set; } = 3; 

    [JsonPropertyName("intervalTime_")]
    public float IntervalTime { get; set; } = 1f; 
}

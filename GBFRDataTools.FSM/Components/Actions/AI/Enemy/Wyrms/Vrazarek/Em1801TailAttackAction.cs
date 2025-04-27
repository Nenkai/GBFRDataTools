using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
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
    public bool IsSingleTarget { get; set; } = true; // Offset 0x30

    [JsonPropertyName("eruptionNum_")]
    public int EruptionNum { get; set; } = 3; // Offset 0x34

    [JsonPropertyName("intervalTime_")]
    public float IntervalTime { get; set; } = 1f; // Offset 0x38

    public Em1801MagmaEruptionAction()
    {
    }
}

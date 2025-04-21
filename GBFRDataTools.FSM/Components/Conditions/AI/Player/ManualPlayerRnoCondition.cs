using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Player;

public class ManualPlayerRnoCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ManualPlayerRnoCondition);

    [JsonPropertyName("checkRno_")]
    public int CheckRno { get; set; } = 0;

    [JsonPropertyName("isTrigger_")]
    public bool IsTrigger { get; set; } = false;

    [JsonPropertyName("isActionStartCheck_")]
    public bool IsActionStartCheck { get; set; } = false;
}

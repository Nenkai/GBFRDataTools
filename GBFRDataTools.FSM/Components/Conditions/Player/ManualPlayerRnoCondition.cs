using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class ManualPlayerRnoCondition : ConditionComponent
{
    [JsonPropertyName("checkRno_")]
    public int CheckRno { get; set; }

    [JsonPropertyName("isTrigger_")]
    public bool IsTrigger { get; set; }

    [JsonPropertyName("isActionStartCheck_")]
    public bool IsActionStartCheck { get; set; }
}

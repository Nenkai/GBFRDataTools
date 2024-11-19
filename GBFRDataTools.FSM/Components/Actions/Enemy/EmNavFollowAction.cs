using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmNavFollowAction : ActionComponent
{
    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; }

    [JsonPropertyName("turnMaxDegree_")]
    public float TurnMaxDegree { get; set; }

    [JsonPropertyName("turnOffsetDegree_")]
    public float TurnOffsetDegree { get; set; }

    [JsonPropertyName("attackHomingFlagOnly_")]
    public bool AttackHomingFlagOnly { get; set; }

    [JsonPropertyName("navRecalcSec_")]
    public float NavRecalcSec { get; set; }
}

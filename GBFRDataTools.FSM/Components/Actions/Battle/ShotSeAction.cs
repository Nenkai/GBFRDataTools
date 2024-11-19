
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

public class ShotSeAction : ActionComponent
{
    [JsonPropertyName("seName_")]
    public string SeName { get; set; }

    [JsonPropertyName("isWorldPositionSet_")]
    public bool IsWorldPositionSet { get; set; }

    [JsonPropertyName("isStopForTerminate_")]
    public bool IsStopForTerminate { get; set; }

    [JsonPropertyName("isStopOtherSe_")]
    public bool IsStopOtherSe { get; set; }

    [JsonPropertyName("isMaterialCheck_")]
    public bool IsMaterialCheck { get; set; }

    [JsonPropertyName("materialCheckHigh_")]
    public float MaterialCheckHigh { get; set; }

    [JsonPropertyName("materialCheckLow_")]
    public float MaterialCheckLow { get; set; }
}
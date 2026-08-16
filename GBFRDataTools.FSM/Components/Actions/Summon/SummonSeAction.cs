using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonSeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSeAction);

    [JsonPropertyName("seName_")]
    public string SeName { get; set; }

    [JsonPropertyName("isWorldPositionSet_")]
    public bool IsWorldPositionSet { get; set; } = false;

    [JsonPropertyName("isStopForTerminate_")]
    public bool IsStopForTerminate { get; set; } = false;

    [JsonPropertyName("isStopOtherSe_")]
    public bool IsStopOtherSe { get; set; } = false;

    [JsonPropertyName("isMaterialCheck_")]
    public bool IsMaterialCheck { get; set; } = false;

    [JsonPropertyName("materialCheckHigh_")]
    public float MaterialCheckHigh { get; set; } = 1f;

    [JsonPropertyName("materialCheckLow_")]
    public float MaterialCheckLow { get; set; } = -1f;

    [JsonPropertyName("seControlName_")]
    public string SeControlName { get; set; }

    [JsonPropertyName("isControlSe_")]
    public bool IsControlSe { get; set; } = false;

    [JsonPropertyName("blackBoardValueName_")]
    public string BlackBoardValueName { get; set; } 
}

using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[GameSupport(GameVersion.EndlessRagnarok)]
public class BlackBoardVecLerpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardVecLerpAction);

    [JsonPropertyName("valueName_")]
    public string ValueName { get; set; }

    [JsonPropertyName("hashValue_")]
    public uint HashValue { get; set; } = 0;

    [JsonPropertyName("targetValue_")]
    public Vector4 TargetValue { get; set; } = Vector4.UnitW;

    [JsonPropertyName("lerpSec_")]
    public float LerpSec { get; set; } = 0.1f;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();
}

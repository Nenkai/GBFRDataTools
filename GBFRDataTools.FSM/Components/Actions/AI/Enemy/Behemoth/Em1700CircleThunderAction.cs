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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700CreateThunderLineAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700CreateThunderLineAction);

    [JsonPropertyName("waitFrame_")]
    public float WaitFrame { get; set; } = 0f;

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("thunderCount_")]
    public int ThunderCount { get; set; } = 1;

    [JsonPropertyName("createIntercval_")]
    public float CreateIntercval { get; set; } = 0f;

    [JsonPropertyName("intervalDist_")]
    public float IntervalDist { get; set; } = 0f;

    [JsonPropertyName("offsetRotY_")]
    public float OffsetRotY { get; set; } = 0f;

    [JsonPropertyName("userCustomType_")]
    public int UserCustomType { get; set; } = 0;
}

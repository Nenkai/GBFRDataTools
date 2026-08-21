using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700CircleThunderAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700CircleThunderAction);

    [JsonPropertyName("isCreateThunder_")]
    public bool IsCreateThunder { get; set; } = false;

    [JsonPropertyName("createThunderIntervalTime_")]
    public float CreateThunderIntervalTime { get; set; } = 0.1f;

    [JsonPropertyName("createThunderNum_")]
    public int CreateThunderNum { get; set; } = 15;

    [JsonPropertyName("thunderRadius_")]
    public float ThunderRadius { get; set; } = 10f;

    [JsonPropertyName("thunderOffsetPos_")]
    public Vector4 ThunderOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("thunderRandomLength_")]
    public float ThunderRandomLength { get; set; } = 5f;

    [JsonPropertyName("thunderScale_")]
    public float ThunderScale { get; set; } = 1f;

    [JsonPropertyName("userCustomType_")]
    public int UserCustomType { get; set; } = 0;
}

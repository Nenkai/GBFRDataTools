using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class PlayerPosCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerPosCondition);

    [JsonPropertyName("pos_")]
    public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 1.0f;

    [JsonPropertyName("height_")]
    public float Height { get; set; } = 1.0f;

    [JsonPropertyName("playerCount_")]
    public int PlayerCount { get; set; } = 1;

    [JsonPropertyName("isCheckOnlyXZ_")]
    public bool IsCheckOnlyXZ { get; set; } = true;

    [JsonPropertyName("isOffset_")]
    public bool IsOffset { get; set; } = false;

    [JsonPropertyName("isManualPlayer_")]
    public bool IsManualPlayer { get; set; } = false;
}

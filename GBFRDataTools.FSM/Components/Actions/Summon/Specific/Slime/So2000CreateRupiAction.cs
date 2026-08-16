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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Slime;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So2000CreateRupiAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So2000CreateRupiAction);

    [JsonPropertyName("slimeType_")]
    public int SlimeType { get; set; } = 0;

    [JsonPropertyName("rupiDamageMul_")]
    public float RupiDamageMul { get; set; } = 0.001f;

    [JsonPropertyName("rupiMaxSilver2_")]
    public int RupiMaxSilver2 { get; set; } = 19285;

    [JsonPropertyName("rupiMaxSilver3_")]
    public int RupiMaxSilver3 { get; set; } = 22393;

    [JsonPropertyName("rupiMaxGold2_")]
    public int RupiMaxGold2 { get; set; } = 22500;

    [JsonPropertyName("rupiMaxGold3_")]
    public int RupiMaxGold3 { get; set; } = 26110;

    [JsonPropertyName("jumpRate_")]
    public float JumpRate { get; set; } = 0.5f;

    [JsonPropertyName("jumpRateMulXZ_")]
    public float JumpRateMulXZ { get; set; } = 1f;
}

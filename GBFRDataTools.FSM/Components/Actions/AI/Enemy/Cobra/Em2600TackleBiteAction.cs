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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600TackleBiteAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600TackleBiteAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; 

    [JsonPropertyName("homingAngleEnd_")]
    public float HomingAngleEnd { get; set; } = 1f; 

    [JsonPropertyName("isLookFoundTarget_")]
    public bool IsLookFoundTarget { get; set; } = false; 

    [JsonPropertyName("isPoisonAttribute_")]
    public bool IsPoisonAttribute { get; set; } = false; 

    [JsonPropertyName("isShotPoisonGas_")]
    public bool IsShotPoisonGas { get; set; } = false; 

    [JsonPropertyName("shotGasNum_")]
    public int ShotGasNum { get; set; } = 4; 

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("tackleDirLimitDeg_")]
    public float TackleDirLimitDeg { get; set; } = 90f; 

    [JsonPropertyName("tackleDirLength_")]
    public float TackleDirLength { get; set; } = 30f; 

    [JsonPropertyName("takcleRotAdjustRate_")]
    public float TakcleRotAdjustRate { get; set; } = 1f; 

    [JsonPropertyName("takcleRotAdjustMax_")]
    public float TakcleRotAdjustMax { get; set; } = 3f; 

    [JsonPropertyName("startEffectId_")]
    public int StartEffectId { get; set; } = 201; 

    [JsonPropertyName("attackEffectId_")]
    public int AttackEffectId { get; set; } = 200; 

    [JsonPropertyName("startPoisonEffectId_")]
    public int StartPoisonEffectId { get; set; } = 211; 

    [JsonPropertyName("attackPoisonEffectId_")]
    public int AttackPoisonEffectId { get; set; } = 210; 
}


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
    public float HomingAngle { get; set; } = 5f; // Offset 0x48

    [JsonPropertyName("homingAngleEnd_")]
    public float HomingAngleEnd { get; set; } = 1f; // Offset 0x4C

    [JsonPropertyName("isLookFoundTarget_")]
    public bool IsLookFoundTarget { get; set; } = false; // Offset 0x50

    [JsonPropertyName("isPoisonAttribute_")]
    public bool IsPoisonAttribute { get; set; } = false; // Offset 0x51

    [JsonPropertyName("isShotPoisonGas_")]
    public bool IsShotPoisonGas { get; set; } = false; // Offset 0x52

    [JsonPropertyName("shotGasNum_")]
    public int ShotGasNum { get; set; } = 4; // Offset 0x54

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x60

    [JsonPropertyName("tackleDirLimitDeg_")]
    public float TackleDirLimitDeg { get; set; } = 90f; // Offset 0x70

    [JsonPropertyName("tackleDirLength_")]
    public float TackleDirLength { get; set; } = 30f; // Offset 0x74

    [JsonPropertyName("takcleRotAdjustRate_")]
    public float TakcleRotAdjustRate { get; set; } = 1f; // Offset 0x78

    [JsonPropertyName("takcleRotAdjustMax_")]
    public float TakcleRotAdjustMax { get; set; } = 3f; // Offset 0x7C

    [JsonPropertyName("startEffectId_")]
    public int StartEffectId { get; set; } = 201; // Offset 0x80

    [JsonPropertyName("attackEffectId_")]
    public int AttackEffectId { get; set; } = 200; // Offset 0x84

    [JsonPropertyName("startPoisonEffectId_")]
    public int StartPoisonEffectId { get; set; } = 211; // Offset 0x88

    [JsonPropertyName("attackPoisonEffectId_")]
    public int AttackPoisonEffectId { get; set; } = 210; // Offset 0x8C

    public Em2600TackleBiteAction()
    {
    }
}


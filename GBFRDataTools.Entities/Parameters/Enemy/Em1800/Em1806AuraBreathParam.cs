using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1800;

public class Em1806AuraBreathParam // Em1806AuraBreath::Param
{
    [JsonPropertyName("maxLength_")]
    public float MaxLength { get; set; } // Offset 0x10

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } // Offset 0x14

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x18

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x1C

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } // Offset 0x20

    [JsonPropertyName("attackEndRadius_")]
    public float AttackEndRadius { get; set; } // Offset 0x24

    [JsonPropertyName("attackScaleSec_")]
    public float AttackScaleSec { get; set; } // Offset 0x28

    [JsonPropertyName("attackDelaySec_")]
    public float AttackDelaySec { get; set; } // Offset 0x2C

    [JsonPropertyName("shotVecCalcType_")]
    public int ShotVecCalcType { get; set; } // Offset 0x30

    [JsonPropertyName("shotStartParts_")]
    public int ShotStartParts { get; set; } // Offset 0x34

    [JsonPropertyName("startOffset_")]
    public Vector4 StartOffset { get; set; } // Offset 0x40

    [JsonPropertyName("atkCollisionOffsetDist_")]
    public float AtkCollisionOffsetDist { get; set; } // Offset 0xCC

    [JsonPropertyName("shotVecBaseParts_")]
    public int ShotVecBaseParts { get; set; } // Offset 0x50

    [JsonPropertyName("shotDirOffsetDeg_")]
    public Vector4 ShotDirOffsetDeg { get; set; } // Offset 0x60

    [JsonPropertyName("enablePartsDirRotX_")]
    public bool EnablePartsDirRotX { get; set; } // Offset 0x70

    [JsonPropertyName("checkGroundLength_")]
    public float CheckGroundLength { get; set; } // Offset 0x74

    [JsonPropertyName("isFixedEndHeight_")]
    public bool IsFixedEndHeight { get; set; } // Offset 0x78

    [JsonPropertyName("fixedHeightOffset_")]
    public float FixedHeightOffset { get; set; } // Offset 0x7C

    [JsonPropertyName("isMultiHit_")]
    public bool IsMultiHit { get; set; } // Offset 0x80

    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; } // Offset 0x84

    [JsonPropertyName("isBgHitEnable_")]
    public bool IsBgHitEnable { get; set; } // Offset 0x88

    [JsonPropertyName("bgHitRadius_")]
    public float BgHitRadius { get; set; } // Offset 0x8C

    [JsonPropertyName("isUseAfterFire_")]
    public bool IsUseAfterFire { get; set; } // Offset 0x90

    [JsonPropertyName("afterFireAtkRate_")]
    public float AfterFireAtkRate { get; set; } // Offset 0x94

    [JsonPropertyName("afterFireBreakRate_")]
    public float AfterFireBreakRate { get; set; } // Offset 0x98

    [JsonPropertyName("afterFireRadius_")]
    public float AfterFireRadius { get; set; } // Offset 0x9C

    [JsonPropertyName("afterFireEndRadius_")]
    public float AfterFireEndRadius { get; set; } // Offset 0xA0

    [JsonPropertyName("afterFireScaleSec_")]
    public float AfterFireScaleSec { get; set; } // Offset 0xA4

    [JsonPropertyName("afterFireType_")]
    public int AfterFireType { get; set; } // Offset 0xA8

    [JsonPropertyName("afterFireOffset_")]
    public Vector4 AfterFireOffset { get; set; } // Offset 0xB0

    [JsonPropertyName("laserEstId_")]
    public int LaserEstId { get; set; } // Offset 0xC0

    [JsonPropertyName("endPointEstId_")]
    public int EndPointEstId { get; set; } // Offset 0xC4

    [JsonPropertyName("effectTimeScale_")]
    public float EffectTimeScale { get; set; } // Offset 0xC8

    [JsonPropertyName("laserSeDefineName_")]
    public string LaserSeDefineName { get; set; } // Offset 0xD0

    [JsonPropertyName("endPointSeDefineName_")]
    public string EndPointSeDefineName { get; set; } // Offset 0xF0

    public Em1806AuraBreathParam()
    {
    }
}
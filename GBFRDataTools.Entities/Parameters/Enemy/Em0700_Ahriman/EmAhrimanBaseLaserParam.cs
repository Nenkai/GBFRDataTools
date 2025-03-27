using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0700_Ahriman;

public class EmAhrimanBaseLaserParam
{
    [JsonPropertyName("type_")]
    public int Type { get; set; } // Offset 0x8

    [JsonPropertyName("size_")]
    public float Size { get; set; } // Offset 0xC

    [JsonPropertyName("length_")]
    public float Length { get; set; } // Offset 0x10

    [JsonPropertyName("aliveSec_")]
    public float AliveSec { get; set; } // Offset 0x14

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } // Offset 0x18

    [JsonPropertyName("offsetZ_")]
    public float OffsetZ { get; set; } // Offset 0x1C

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x20

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x24

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; } // Offset 0x28

    [JsonPropertyName("hitFlag_")]
    public ulong HitFlag { get; set; } // Offset 0x30

    [JsonPropertyName("element_")]
    public int Element { get; set; } // Offset 0x38

    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; } // Offset 0x50

    [JsonPropertyName("isMultiHit_")]
    public bool IsMultiHit { get; set; } // Offset 0x54

    [JsonPropertyName("isDamageBreakObject_")]
    public bool IsDamageBreakObject { get; set; } // Offset 0x55

    [JsonPropertyName("debuffAilmentCategory_")]
    public int DebuffAilmentCategory { get; set; } // Offset 0x3C

    [JsonPropertyName("debuffAlimentType_")]
    public int DebuffAlimentType { get; set; } // Offset 0x40

    [JsonPropertyName("debuffType_")]
    public int DebuffType { get; set; } // Offset 0x44

    [JsonPropertyName("debuffTime_")]
    public float DebuffTime { get; set; } // Offset 0x48

    [JsonPropertyName("debuffRate_")]
    public float DebuffRate { get; set; } // Offset 0x4C

    [JsonPropertyName("defaultMoveDegX_")]
    public float DefaultMoveDegX { get; set; } // Offset 0x58

    [JsonPropertyName("isAdjustEyeRotX_")]
    public bool IsAdjustEyeRotX { get; set; } // Offset 0x5C

    [JsonPropertyName("isAdjustEyeRotY_")]
    public bool IsAdjustEyeRotY { get; set; } // Offset 0x5D

    [JsonPropertyName("homingMinRot_")]
    public float HomingMinRot { get; set; } // Offset 0x60

    [JsonPropertyName("homingMaxRot_")]
    public float HomingMaxRot { get; set; } // Offset 0x64

    [JsonPropertyName("homingSpdRot_")]
    public float HomingSpdRot { get; set; } // Offset 0x68

    [JsonPropertyName("homingRotSpdRate_")]
    public float HomingRotSpdRate { get; set; } // Offset 0x6C

    [JsonPropertyName("effectObjId_")]
    [eObjId]
    public int EffectObjId { get; set; } // Offset 0x70

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; } // Offset 0x74

    [JsonPropertyName("laserEffectId_")]
    public int LaserEffectId { get; set; } // Offset 0x78

    [JsonPropertyName("laserTipEffectId_")]
    public int LaserTipEffectId { get; set; } // Offset 0x7C

    [JsonPropertyName("hitEffectId_")]
    public int HitEffectId { get; set; } // Offset 0xC0

    [JsonPropertyName("laserSeDefineName_")]
    public string LaserSeDefineName { get; set; } // Offset 0x80

    [JsonPropertyName("laserSeDefineNameEnd_")]
    public string LaserSeDefineNameEnd { get; set; } // Offset 0xA0

    [JsonPropertyName("hitSeDefineName_")]
    public string HitSeDefineName { get; set; } // Offset 0xC8

    [JsonPropertyName("callSeWallHit_")]
    public bool CallSeWallHit { get; set; } // Offset 0xE8

    [JsonPropertyName("shotSeDefineName_")]
    public string ShotSeDefineName { get; set; } // Offset 0xF0

    public EmAhrimanBaseLaserParam()
    {
    }
}
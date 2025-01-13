using GBFRDataTools.Entities.Parameters.Base;

using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Weapon.We2100;

public class SuperiorWeMoveParam
{
    [JsonPropertyName("moveSpeedRate_")]
    public float[] MoveSpeedRate { get; set; } = new float[4]; // Offset 0x8

    [JsonPropertyName("jumpHeightY_")]
    public float JumpHeightY { get; set; } // Offset 0x18

    [JsonPropertyName("isMoveSec_")]
    public bool IsMoveSec { get; set; } // Offset 0x1C

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } // Offset 0x20

    [JsonPropertyName("addAngleY_")]
    public float AddAngleY { get; set; } // Offset 0x24

    [JsonPropertyName("randomRangeY_")]
    public float RandomRangeY { get; set; } // Offset 0x28

    [JsonPropertyName("ownerDist_")]
    public float OwnerDist { get; set; } // Offset 0x2C

    [JsonPropertyName("offsetDist_")]
    public float OffsetDist { get; set; } // Offset 0x30

    [JsonPropertyName("isTargetPlayer_")]
    public bool IsTargetPlayer { get; set; } // Offset 0x34

    [JsonPropertyName("interpType_")]
    public int InterpType { get; set; } // Offset 0x38

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } // Offset 0xCF543FFA

    public SuperiorWeMoveParam()
    {
    }
}
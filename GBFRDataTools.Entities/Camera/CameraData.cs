using GBFRDataTools.Entities.Parameters.Player;

using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Camera;

public class CameraData
{
    [JsonPropertyName("cameraDistance_")]
    public float CameraDistance { get; set; } // Offset 0x14

    [JsonPropertyName("fovy_")]
    public float Fovy { get; set; } // Offset 0x18

    [JsonPropertyName("cameraInterRate_")]
    [Obsolete("Not used by the game")]
    public float CameraInterRate { get; set; } // Offset 0x20

    [JsonPropertyName("interRate_")]
    public float InterRate { get; set; } // Offset 0x20

    [JsonPropertyName("priority_")]
    public int Priority { get; set; } // Offset 0x10

    [JsonPropertyName("targetPointOffset_")]
    public Vector4 TargetPointOffset { get; set; } // Offset 0x30

    [JsonPropertyName("dataInterSec_")]
    public float DataInterSec { get; set; } // Offset 0x40

    [JsonPropertyName("addRotationX_")]
    public float AddRotationX { get; set; } // Offset 0x24

    [JsonPropertyName("isFixedRotationX_")]
    public bool IsFixedRotationX { get; set; } // Offset 0x44

    [JsonPropertyName("fixedRotationX_")]
    public float FixedRotationX { get; set; } // Offset 0x48

    [JsonPropertyName("fixedControlBiasX_")]
    public float FixedControlBiasX { get; set; } // Offset 0x4C

    [JsonPropertyName("enableAutoAdjustMoving_")]
    public bool EnableAutoAdjustMoving { get; set; } // Offset 0x50

    [JsonPropertyName("canControl_")]
    public bool CanControl { get; set; } // Offset 0x51

    [JsonPropertyName("controlAngleXSpeed_")]
    public float ControlAngleXSpeed { get; set; } // Offset 0x54

    [JsonPropertyName("controlAngleYSpeed_")]
    public float ControlAngleYSpeed { get; set; } // Offset 0x58

    [JsonPropertyName("dataName_")]
    [Obsolete("Not used by the game")]
    public string DataName { get; set; } // Offset 0x60

    [JsonPropertyName("fileName_")]
    public string FileName { get; set; } // Offset 0x60
}



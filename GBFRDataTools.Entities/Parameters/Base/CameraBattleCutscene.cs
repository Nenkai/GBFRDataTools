using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class CameraBattleCutsceneAttachParam
{
    [JsonPropertyName("lookAtOffset_")]
    public Vector3 LookAtOffset { get; set; } // Offset 0x20

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; } // Offset 0x2C

    [JsonPropertyName("rotX_")]
    public float RotX { get; set; } // Offset 0x30

    [JsonPropertyName("rotY_")]
    public float RotY { get; set; } // Offset 0x34

    [JsonPropertyName("distance_")]
    public float Distance { get; set; } // Offset 0x38

    [JsonPropertyName("fov_")]
    public float Fov { get; set; } // Offset 0x3C

    [JsonPropertyName("isAttachContinue_")]
    public bool IsAttachContinue { get; set; } // Offset 0x40

    public CameraBattleCutsceneAttachParam()
    {
    }
}

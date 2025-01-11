using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class CharaCollisionParam
{
    [JsonPropertyName("offset_")]
    public /* cVec4 */ Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("lineEndOffset_")]
    public /* cVec4 */ Vector4 LineEndOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; } = -1;

    [JsonPropertyName("capsuleEndPartsNumber_")]
    public int CapsuleEndPartsNumber { get; set; } = -1;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 1.0f;
}

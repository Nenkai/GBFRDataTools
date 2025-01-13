using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7400;

public class Em7400ShakeParam
{
    [JsonPropertyName("widthMax_")]
    public Vector4 WidthMax { get; set; } // Offset 0x10

    [JsonPropertyName("widthMin_")]
    public Vector4 WidthMin { get; set; } // Offset 0x20

    [JsonPropertyName("shakeSec_")]
    public Vector4 ShakeSec { get; set; } // Offset 0x30

    [JsonPropertyName("shakeNum_")]
    public Vector4 ShakeNum { get; set; } // Offset 0x40

    public Em7400ShakeParam()
    {
    }
}
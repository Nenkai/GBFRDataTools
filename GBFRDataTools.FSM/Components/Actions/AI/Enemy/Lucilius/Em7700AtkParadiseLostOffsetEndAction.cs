using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkParadiseLostOffsetEndAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkParadiseLostOffsetEndAction);

    [JsonPropertyName("resetPlayerDistance_")]
    public float ResetPlayerDistance { get; set; } = 20f; // Offset 0x74

    [JsonPropertyName("em7700Pos_")]
    public Vector4 Em7700Pos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x80

    [JsonPropertyName("em7700RotY_")]
    public float Em7700RotY { get; set; } = 0f; // Offset 0x90

    [JsonPropertyName("pl2100Pos_")]
    public Vector4 Pl2100Pos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xA0

    [JsonPropertyName("pl2100RotY_")]
    public float Pl2100RotY { get; set; } = 0f; // Offset 0xB0

    public Em7700AtkParadiseLostOffsetEndAction()
    {
    }
}



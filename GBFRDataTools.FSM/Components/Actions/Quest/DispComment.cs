using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[Obsolete("Debug only, stripped in release builds")]
public class DispComment : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DispComment);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0;

    [JsonPropertyName("text_")]
    public string? Text { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1.0f;

    [JsonPropertyName("color_")]
    public /* cVec4 */ Vector4 Color { get; set; } = new Vector4(255, 255, 255, 255);

    public override string? GetCaption()
    {
        return $"Text: {Text}, Time: {Time:F2}s";
    }
}

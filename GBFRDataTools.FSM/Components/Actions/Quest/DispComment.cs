using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DispComment : QuestActionComponent
{
    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0;

    [JsonPropertyName("text_")]
    public string Text { get; set; } = string.Empty;

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1.0f;

    [JsonPropertyName("color_")]
    public /* cVec4 */ Vector4 Color { get; set; } = new Vector4(255, 255, 255, 255);
}

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

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DispComment : QuestActionComponent
{
    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("text_")]
    public string Text { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; }

    [JsonPropertyName("color_")]
    public cVec4 Color { get; set; }
}

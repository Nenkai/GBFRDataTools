using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300SpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300SpecialArtsAction);

    [JsonPropertyName("setInterval_")]
    public Vector4 SetInterval { get; set; } = new Vector4(4f, 0f, 0f, 1f); // Offset 0x120

    [JsonPropertyName("slashInterval_")]
    public Vector4 SlashInterval { get; set; } = new Vector4(0.8f, 0.8f, 0.8f, 1f); // Offset 0x130

    [JsonPropertyName("slashAppearTime_")]
    public float SlashAppearTime { get; set; } = 2f; // Offset 0x140

    [JsonPropertyName("slashEndIdleTime_")]
    public float SlashEndIdleTime { get; set; } = 1.5f; // Offset 0x144

    [JsonPropertyName("changeEndIdleTime_")]
    public float ChangeEndIdleTime { get; set; } = 1f; // Offset 0x148

    [JsonPropertyName("endIdleTime_")]
    public float EndIdleTime { get; set; } = 1f; // Offset 0x14C

    public Em7300SpecialArtsAction()
    {
    }
}

using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Pincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2510AtkExAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510AtkExAction);

    [JsonPropertyName("rushMinTime_")]
    public float RushMinTime { get; set; } = 0.5f; // Offset 0x88

    [JsonPropertyName("rushMaxTime_")]
    public float RushMaxTime { get; set; } = 5f; // Offset 0x8C

    [JsonPropertyName("rushLoopNum_")]
    public int RushLoopNum { get; set; } = 1; // Offset 0x80

    [JsonPropertyName("rushMoveRate_")]
    public BindingList<float> RushMoveRate { get; set; } = [.. Enumerable.Repeat(0.0f, 4).ToList()]; // std::array<float,4>

    [JsonPropertyName("homingRotRate_")]
    public float HomingRotRate { get; set; } = 0.3f; // Offset 0xA0

    public Em2510AtkExAction()
    {
        Guid = 0;
        ParentGuid = 0xFFFFFFFF;
    }
}

using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public float RushMinTime { get; set; } = 0.5f; 

    [JsonPropertyName("rushMaxTime_")]
    public float RushMaxTime { get; set; } = 5f; 

    [JsonPropertyName("rushLoopNum_")]
    public int RushLoopNum { get; set; } = 1; 

    [JsonPropertyName("rushMoveRate_")]
    [Editable(false)]
    public BindingList<float> RushMoveRate { get; set; } = [.. Enumerable.Repeat(0.0f, 4).ToList()]; // std::array<float,4>

    [JsonPropertyName("homingRotRate_")]
    public float HomingRotRate { get; set; } = 0.3f; 
}

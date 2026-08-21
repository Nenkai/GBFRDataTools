using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500RockGeyserAction : Em1500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500RockGeyserAction);

    [JsonPropertyName("intervalFrame_")]
    public int IntervalFrame { get; set; } = 3; 

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 10; 

    [JsonPropertyName("is3Way_")]
    public bool Is3Way { get; set; } = false; 

    [JsonPropertyName("rot3Way_")]
    public float Rot3Way { get; set; } = 30f; 

    [JsonPropertyName("is5Way_")]
    public bool Is5Way { get; set; } = false; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.1f; 

    [JsonPropertyName("homingRotSpeed_")]
    public float HomingRotSpeed { get; set; } = 45f; 

    [JsonPropertyName("isHomingPassing_")]
    public bool IsHomingPassing { get; set; } = false; 

    [JsonPropertyName("isLinkAILevel_")]
    public bool IsLinkAILevel { get; set; } = false; 

    [JsonPropertyName("isHomingSound_")]
    public bool IsHomingSound { get; set; } = false; 
}
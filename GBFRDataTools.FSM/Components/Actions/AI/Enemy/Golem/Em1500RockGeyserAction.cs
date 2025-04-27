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
    public int IntervalFrame { get; set; } = 3; // Offset 0x3C

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 10; // Offset 0x40

    [JsonPropertyName("is3Way_")]
    public bool Is3Way { get; set; } = false; // Offset 0x44

    [JsonPropertyName("rot3Way_")]
    public float Rot3Way { get; set; } = 30f; // Offset 0x48

    [JsonPropertyName("is5Way_")]
    public bool Is5Way { get; set; } = false; // Offset 0x4C

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.1f; // Offset 0x50

    [JsonPropertyName("homingRotSpeed_")]
    public float HomingRotSpeed { get; set; } = 45f; // Offset 0x54

    [JsonPropertyName("isHomingPassing_")]
    public bool IsHomingPassing { get; set; } = false; // Offset 0x58

    [JsonPropertyName("isLinkAILevel_")]
    public bool IsLinkAILevel { get; set; } = false; // Offset 0x59

    [JsonPropertyName("isHomingSound_")]
    public bool IsHomingSound { get; set; } = false; // Offset 0x5A

    public Em1500RockGeyserAction()
    {
    }
}
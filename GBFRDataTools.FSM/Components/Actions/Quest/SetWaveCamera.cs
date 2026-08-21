using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetWaveCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetWaveCamera);

    [JsonPropertyName("enableOffsetWave_")]
    public bool EnableOffsetWave { get; set; } = false; 

    [JsonPropertyName("offsetWaveOffset_")]
    public Vector2 OffsetWaveOffset { get; set; } = Vector2.Zero; 

    [JsonPropertyName("offsetWaveSpan_")]
    public Vector2 OffsetWaveSpan { get; set; } = Vector2.Zero; 
}

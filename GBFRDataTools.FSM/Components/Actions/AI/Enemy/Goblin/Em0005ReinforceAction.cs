using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005ReinforceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005ReinforceAction);

    [JsonPropertyName("isShield_")]
    public bool IsShield { get; set; } = false; 

    [JsonPropertyName("cameraTimer_")]
    public float CameraTimer { get; set; } = 1f; 

    [JsonPropertyName("param0_")]
    public SpawnParam Param0 { get; set; } = new(); 

    [JsonPropertyName("param1_")]
    public SpawnParam Param1 { get; set; } = new(); 

    [JsonPropertyName("param2_")]
    public SpawnParam Param2 { get; set; } = new(); 

    [JsonPropertyName("param3_")]
    public SpawnParam Param3 { get; set; } = new(); 

    [JsonPropertyName("param4_")]
    public SpawnParam Param4 { get; set; } = new(); 

    [JsonPropertyName("delayVoiceTimer_")]
    public float DelayVoiceTimer { get; set; } = 0f; 

    public class SpawnParam
    {
        [JsonPropertyName("gobrinId_")]
        public int GobrinId { get; set; } 

        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } 

        [JsonPropertyName("type_")]
        public int Type { get; set; } 
    }
}

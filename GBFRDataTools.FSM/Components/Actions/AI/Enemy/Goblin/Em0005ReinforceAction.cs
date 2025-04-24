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
    public bool IsShield { get; set; } = false; // Offset 0x30

    [JsonPropertyName("cameraTimer_")]
    public float CameraTimer { get; set; } = 1f; // Offset 0x34

    [JsonPropertyName("param0_")]
    public SpawnParam Param0 { get; set; } = new(); // Offset 0x50

    [JsonPropertyName("param1_")]
    public SpawnParam Param1 { get; set; } = new(); // Offset 0x90

    [JsonPropertyName("param2_")]
    public SpawnParam Param2 { get; set; } = new(); // Offset 0xD0

    [JsonPropertyName("param3_")]
    public SpawnParam Param3 { get; set; } = new(); // Offset 0x110

    [JsonPropertyName("param4_")]
    public SpawnParam Param4 { get; set; } = new(); // Offset 0x150

    [JsonPropertyName("delayVoiceTimer_")]
    public float DelayVoiceTimer { get; set; } = 0f; // Offset 0x1B8

    public Em0005ReinforceAction()
    {
    }

    public class SpawnParam
    {
        [JsonPropertyName("gobrinId_")]
        public int GobrinId { get; set; } // Offset 0x10

        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } // Offset 0x20

        [JsonPropertyName("type_")]
        public int Type { get; set; } // Offset 0x30

        public SpawnParam()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100JumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100JumpAction);

    [JsonPropertyName("jumpSec_")]
    public float JumpSec { get; set; } = 3f; // Offset 0x38

    [JsonPropertyName("maxHeight_")]
    public float MaxHeight { get; set; } = 9.6f; // Offset 0x34

    [JsonPropertyName("changeLandingOffsetSec_")]
    public float ChangeLandingOffsetSec { get; set; } = 0.5f; // Offset 0x3C

    [JsonPropertyName("ignoreSubHp_")]
    public bool IgnoreSubHp { get; set; } = true; // Offset 0x40

    [JsonPropertyName("voiceType_")]
    public int VoiceType { get; set; } = 0; // Offset 0x44

    public Em2100JumpAction()
    {
    }
}
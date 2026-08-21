using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000JumpAppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0000JumpAppearAction);

    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; } = 0f; 

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0f; 

    [JsonPropertyName("isChangeMotion_")]
    public bool IsChangeMotion { get; set; } = false; 
}

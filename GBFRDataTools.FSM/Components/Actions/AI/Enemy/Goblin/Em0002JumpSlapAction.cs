using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002JumpSlapAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002JumpSlapAction);

    [JsonPropertyName("jumpSpeed_")]
    public float JumpSpeed { get; set; } = 0f; // Offset 0xB0

    [JsonPropertyName("isCounter_")]
    public bool IsCounter { get; set; } = false; // Offset 0xB4

    public Em0002JumpSlapAction()
    {
    }
}

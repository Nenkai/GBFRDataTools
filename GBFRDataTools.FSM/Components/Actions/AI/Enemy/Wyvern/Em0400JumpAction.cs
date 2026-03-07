using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyvern;

public class Em0400JumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0400JumpAction);

    [JsonPropertyName("jumpSpeed_")]
    public float JumpSpeed { get; set; } = 0f; // Offset 0x30

    public Em0400JumpAction()
    {
    }
}

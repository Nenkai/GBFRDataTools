using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500TurnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500TurnAction);

    [JsonPropertyName("isLeftMove_")]
    public bool IsLeftMove { get; set; } = true; // Offset 0x70

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 3f; // Offset 0x74

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.05f; // Offset 0x78

    public Em7500TurnAction()
    {
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300TurnAction : EmTurnAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300TurnAction);

    [JsonPropertyName("powerRightMotionId_")]
    public string PowerRightMotionId { get; set; } // Offset 0x50

    [JsonPropertyName("powerLeftMotionId_")]
    public string PowerLeftMotionId { get; set; } // Offset 0x58

    [JsonPropertyName("powerBackMotionId_")]
    public string PowerBackMotionId { get; set; } // Offset 0x60

    [JsonPropertyName("beforeHevyRush_")]
    public bool BeforeHevyRush { get; set; } = false; // Offset 0x68

    public Em7300TurnAction()
    {
    }
}

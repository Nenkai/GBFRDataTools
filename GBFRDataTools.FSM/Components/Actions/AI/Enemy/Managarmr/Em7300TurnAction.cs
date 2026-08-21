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
    public string? PowerRightMotionId { get; set; } = "b062";

    [JsonPropertyName("powerLeftMotionId_")]
    public string? PowerLeftMotionId { get; set; } = "b063";

    [JsonPropertyName("powerBackMotionId_")]
    public string? PowerBackMotionId { get; set; } = "b064";

    [JsonPropertyName("beforeHevyRush_")]
    public bool BeforeHevyRush { get; set; } = false; 
}

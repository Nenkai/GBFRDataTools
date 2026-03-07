using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600BackRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600BackRushAction);

    [JsonPropertyName("rushTime_")]
    public float RushTime { get; set; } = 0.5f; // Offset 0x44

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1f; // Offset 0x48

    public Em1600BackRushAction()
    {
    }
}

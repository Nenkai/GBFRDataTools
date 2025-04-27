using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Excavallion;

public class Em7404ShotMoveBezierAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7404ShotMoveBezierAction);

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 0f; // Offset 0x30

    [JsonPropertyName("p2Rate_")]
    public float P2Rate { get; set; } = 0f; // Offset 0x34

    [JsonPropertyName("p3Rate_")]
    public float P3Rate { get; set; } = 0f; // Offset 0x38

    [JsonPropertyName("p2Height_")]
    public float P2Height { get; set; } = 0f; // Offset 0x3C

    [JsonPropertyName("p3Height_")]
    public float P3Height { get; set; } = 0f; // Offset 0x40

    public Em7404ShotMoveBezierAction()
    {
    }
}

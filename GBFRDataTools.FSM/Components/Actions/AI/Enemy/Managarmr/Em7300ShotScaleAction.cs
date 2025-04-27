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

public class Em7300ShotScaleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300ShotScaleAction);

    [JsonPropertyName("startScale_")]
    public float StartScale { get; set; } = 1f; // Offset 0x3C

    [JsonPropertyName("endScale_")]
    public float EndScale { get; set; } = 1f; // Offset 0x40

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1f; // Offset 0x44

    public Em7300ShotScaleAction()
    {
    }
}

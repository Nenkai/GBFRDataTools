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

public class Em7300PowerCounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300PowerCounterAction);

    [JsonPropertyName("isOdArts_")]
    public bool IsOdArts { get; set; } = false; // Offset 0xAC

    [JsonPropertyName("odArtsMotionStartTime_")]
    public float OdArtsMotionStartTime { get; set; } = 2f; // Offset 0xB0

    public Em7300PowerCounterAction()
    {
    }
}

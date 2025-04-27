using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520WaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520WaitAction);

    [JsonPropertyName("initPosTime_")]
    public float InitPosTime { get; set; } = 2f; // Offset 0x124

    [JsonPropertyName("canInitPosMoveLength_")]
    public float CanInitPosMoveLength { get; set; } = 20f; // Offset 0x128

    public Em7520WaitAction()
    {
    }
}
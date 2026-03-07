using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520MoveHormingShotAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520MoveHormingShotAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 10f; // Offset 0x134

    public Em7520MoveHormingShotAction()
    {
    }
}

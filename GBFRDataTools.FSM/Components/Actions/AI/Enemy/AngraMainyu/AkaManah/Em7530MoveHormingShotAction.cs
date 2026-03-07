using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530MoveHormingShotAction : Em7530ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530MoveHormingShotAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 10f; // Offset 0xB4

    public Em7530MoveHormingShotAction()
    {
    }
}
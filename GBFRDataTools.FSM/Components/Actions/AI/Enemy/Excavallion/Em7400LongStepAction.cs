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

public class Em7400LongStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7400LongStepAction);

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0; // Offset 0x3C

    public Em7400LongStepAction()
    {
    }
}

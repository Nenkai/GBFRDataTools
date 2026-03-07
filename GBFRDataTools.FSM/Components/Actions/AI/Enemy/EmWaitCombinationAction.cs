using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmWaitCombinationAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmWaitCombinationAction);

    [JsonPropertyName("checkState_")]
    public int CheckState { get; set; } = 0;

    [JsonPropertyName("isMoveAnimSet_")]
    public bool IsMoveAnimSet { get; set; } = true;
}

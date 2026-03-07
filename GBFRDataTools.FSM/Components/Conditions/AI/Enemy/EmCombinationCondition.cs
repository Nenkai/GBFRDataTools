using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmCombinationCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCombinationCondition);

    [JsonPropertyName("checkState_")]
    public int CheckState { get; set; } = 0; // Offset 0x3C

    [JsonPropertyName("blackBoardBoolName_")]
    public string BlackBoardBoolName { get; set; } // Offset 0x40

    public EmCombinationCondition()
    {
    }
}
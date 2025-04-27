using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7600ManagerActionCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600ManagerActionCondition);

    [JsonPropertyName("actionIndex_")]
    public int ActionIndex { get; set; } = 0; // Offset 0x38

    public Em7600ManagerActionCondition()
    {
    }
}

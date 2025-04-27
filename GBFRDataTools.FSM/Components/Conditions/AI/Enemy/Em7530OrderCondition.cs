using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7530OrderCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530OrderCondition);

    [JsonPropertyName("checkOrder_")]
    public int CheckOrder { get; set; } = 0; // Offset 0x38

    public Em7530OrderCondition()
    {
    }
}

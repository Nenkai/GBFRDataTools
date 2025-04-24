using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7001RideDeckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001RideDeckCondition);

    [JsonPropertyName("isRideDeck_")]
    public bool IsRideDeck { get; set; } = false; // Offset 0x38

    public Em7001RideDeckCondition()
    {
    }
}
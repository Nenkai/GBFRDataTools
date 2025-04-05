using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class Em2600PoisonShotSpeedIdCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600PoisonShotSpeedIdCondition);

    [JsonPropertyName("checkSpeedId_")]
    public int CheckSpeedId { get; set; } = 0;
}

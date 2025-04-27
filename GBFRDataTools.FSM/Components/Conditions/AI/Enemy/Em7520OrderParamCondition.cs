using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7520OrderParamCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520OrderParamCondition);

    [JsonPropertyName("checkOrderParam_")]
    public int CheckOrderParam { get; set; } = 0; // Offset 0x38

    public Em7520OrderParamCondition()
    {
    }
}

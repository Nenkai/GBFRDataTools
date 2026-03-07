using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class CommonFsmVFXCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CommonFsmVFXCheckCondition);

    [JsonPropertyName("isAnyVFX_")]
    public bool IsAnyVFX { get; set; } = true;

    [JsonPropertyName("delCode_")]
    public int DelCode { get; set; } = 0;
}

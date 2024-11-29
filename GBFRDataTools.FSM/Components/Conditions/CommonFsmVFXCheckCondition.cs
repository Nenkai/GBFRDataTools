using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions;

public class CommonFsmVFXCheckCondition : ConditionComponent
{
    [JsonPropertyName("isAnyVFX_")]
    public bool IsAnyVFX { get; set; } = true;

    [JsonPropertyName("delCode_")]
    public int DelCode { get; set; } = 0;
}

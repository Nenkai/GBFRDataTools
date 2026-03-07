using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Input;

public class ParentalInputTextCheck : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ParentalInputTextCheck);

    [JsonPropertyName("isStringCheck_")]
    public bool IsStringCheck { get; set; } = true; // Offset 0x38

    [JsonPropertyName("isNumCheck_")]
    public bool IsNumCheck { get; set; } = true; // Offset 0x39

    public ParentalInputTextCheck()
    {
    }
}


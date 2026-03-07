using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Sound;

public class WwiseSingleSeControl : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(WwiseSingleSeControl);

    [JsonPropertyName("seType_")]
    public int SeType { get; set; } = 0; // Offset 0x30
}

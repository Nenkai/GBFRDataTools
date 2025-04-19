using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsWatchedInformationDialog : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsWatchedInformationDialog);

    [JsonPropertyName("informationIDString_")]
    public string InformationIDString { get; set; } // Offset 0x38

    public IsWatchedInformationDialog()
    {
    }
}

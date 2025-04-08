using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class IsSyncFlag : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSyncFlag);

    [JsonPropertyName("flagType_")]
    public EnumString FlagType { get; set; } // Offset 0x38

    [JsonPropertyName("checkType_")]
    public EnumString CheckType { get; set; } // Offset 0x68

    [JsonPropertyName("isClear_")]
    public bool IsClear { get; set; } = false; // Offset 0x98

    [JsonPropertyName("checkFlag_")]
    public bool CheckFlag { get; set; } = true; // Offset 0x99
}

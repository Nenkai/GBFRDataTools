using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsSpoRefreshLoc : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSpoRefreshLoc);

    [JsonPropertyName("modeEnum_")]
    public BindingList<EnumString> ModeEnum { get; set; } = []; // Offset 0x38

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x50

    [JsonPropertyName("isNot_")]
    public bool IsNot { get; set; } = false; // Offset 0x54

    [JsonPropertyName("isQuestFlow_")]
    public EnumString IsQuestFlow { get; set; } // Offset 0x58

    [JsonPropertyName("isNotFlow_")]
    public bool IsNotFlow { get; set; } = false; // Offset 0x88

    [JsonPropertyName("isCheckAny_")]
    public bool IsCheckAny { get; set; } = false; // Offset 0x89
}

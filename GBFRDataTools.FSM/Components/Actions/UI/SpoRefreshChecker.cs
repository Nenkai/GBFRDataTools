using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SpoRefreshChecker : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SpoRefreshChecker);

    [JsonPropertyName("modeEnum_")]
    public EnumString ModeEnum { get; set; } // Offset 0x30

    [JsonPropertyName("checkSelectQuestDelete_")]
    public bool CheckSelectQuestDelete { get; set; } = false; // Offset 0x63

    [JsonPropertyName("checkMyQuestDelete_")]
    public bool CheckMyQuestDelete { get; set; } = false; // Offset 0x60

    [JsonPropertyName("checkPtQuestDelete_")]
    public bool CheckPtQuestDelete { get; set; } = false; // Offset 0x61

    [JsonPropertyName("checkQuestChenge_")]
    public bool CheckQuestChenge { get; set; } = false; // Offset 0x62
}

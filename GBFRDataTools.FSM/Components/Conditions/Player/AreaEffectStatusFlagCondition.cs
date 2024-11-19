using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;
using System.ComponentModel;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class AreaEffectStatusFlagCondition : ConditionComponent
{
    [JsonPropertyName("statusFlagInfo_")]
    public BindingList<StatusFlagInfo> StatusFlagInfo { get; set; }

    [JsonPropertyName("isSuccessAny_")]
    public bool IsSuccessAny { get; set; }

    
}

public class StatusFlagInfo // BT::AreaEffectStatusFlagCondition::StatusFlagInfo
{
    [JsonPropertyName("statusFlag_")]
    public int StatusFlag { get; set; }

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; }
}
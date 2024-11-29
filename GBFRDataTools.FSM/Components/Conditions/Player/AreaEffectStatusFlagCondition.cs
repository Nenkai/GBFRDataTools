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
    public BindingList<AreaEffectStatusFlagCondition_StatusFlagInfo> StatusFlagInfo { get; set; } = [];

    [JsonPropertyName("isSuccessAny_")]
    public bool IsSuccessAny { get; set; } = true;

    public class AreaEffectStatusFlagCondition_StatusFlagInfo // BT::AreaEffectStatusFlagCondition::StatusFlagInfo
    {
        [JsonPropertyName("statusFlag_")]
        public int StatusFlag { get; set; } = 0;

        [JsonPropertyName("isEnable_")]
        public bool IsEnable { get; set; } = true;
    }
}


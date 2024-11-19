using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundPlayerStatusCondition : ConditionComponent
{
    [JsonPropertyName("checkFlag_")]
    public int CheckFlag { get; set; }

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; }

    [JsonPropertyName("checkFlagList_")]
    public BindingList<FlagInfo> CheckFlagList { get; set; }

    public class FlagInfo // BT::SoundPlayerStatusCondition::FlagInfo
    {
        [JsonPropertyName("flagNo_")]
        public int FlagNo { get; set; }

        [JsonPropertyName("isEnable_")]
        public bool IsEnable { get; set; }
    }
}

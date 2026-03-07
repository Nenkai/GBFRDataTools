using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundPlayerStatusCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundPlayerStatusCondition);

    [JsonPropertyName("checkFlag_")]
    public int CheckFlag { get; set; } = -1;

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = false;

    [JsonPropertyName("checkFlagList_")]
    public BindingList<FlagInfo> CheckFlagList { get; set; } = [];

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FlagInfo // BT::SoundPlayerStatusCondition::FlagInfo
    {
        [JsonPropertyName("flagNo_")]
        public int FlagNo { get; set; } = 0;

        [JsonPropertyName("isEnable_")]
        public bool IsEnable { get; set; } = false;
    }
}

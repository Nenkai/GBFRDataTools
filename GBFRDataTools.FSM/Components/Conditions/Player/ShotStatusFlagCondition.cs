using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class ShotStatusFlagCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotStatusFlagCondition);

    [JsonPropertyName("statusFlagInfo_")]
    public BindingList<StatusFlagInfo> StatusFlagInfo { get; set; }

    [JsonPropertyName("isSuccessAny_")]
    public bool IsSuccessAny { get; set; }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class StatusFlagInfo // BT::ShotStatusFlagCondition::StatusFlagInfo
{
    [JsonPropertyName("statusFlag_")]
    public int StatusFlag { get; set; }

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; }
}
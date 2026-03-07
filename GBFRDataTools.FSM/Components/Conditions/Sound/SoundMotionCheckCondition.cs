using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundMotionCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMotionCheckCondition);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } = string.Empty;

    [JsonPropertyName("hash_")]
    public uint Hash { get; set; } = 0;

    [JsonPropertyName("checkType_")]
    public int CheckType { get; set; } = 0;

    [JsonPropertyName("motionDataList_")]
    public BindingList<MotionData> MotionDataList { get; set; } = [];

    [JsonPropertyName("isMaxBlendWeight_")]
    public bool IsMaxBlendWeight { get; set; } = false;
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class MotionData // BT::SoundMotionCheckCondition::MotionData
{
    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = string.Empty;

    [Description("CRC32 hash of MotionId.")]
    [JsonPropertyName("hashValue_")]
    public uint HashValue { get; set; } = 0;
}
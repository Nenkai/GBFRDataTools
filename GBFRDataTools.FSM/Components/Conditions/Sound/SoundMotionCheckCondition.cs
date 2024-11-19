using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundMotionCheckCondition : ConditionComponent
{
    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; }

    [JsonPropertyName("hash_")]
    public uint Hash { get; set; }

    [JsonPropertyName("checkType_")]
    public int CheckType { get; set; }

    [JsonPropertyName("motionDataList_")]
    public BindingList<MotionData> MotionDataList { get; set; }

    [JsonPropertyName("isMaxBlendWeight_")]
    public bool IsMaxBlendWeight { get; set; }

}

public class MotionData // BT::SoundMotionCheckCondition::MotionData
{
    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; }

    [JsonPropertyName("hashValue_")]
    public uint HashValue { get; set; }
}
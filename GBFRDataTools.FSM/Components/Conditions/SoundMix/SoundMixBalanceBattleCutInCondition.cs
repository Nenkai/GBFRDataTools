using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceBattleCutInCondition : ConditionComponent
{
    [JsonPropertyName("isIgnoreType_")]
    public bool IsIgnoreType { get; set; } = true;

    [JsonPropertyName("cutInList_")]
    public BindingList<BattleCutInInfo> CutInList { get; set; } = [];

    public class BattleCutInInfo // SoundMixBalanceBattleCutInCondition::BattleCutInInfo
    {
        [JsonPropertyName("objId_")]
        public uint ObjId { get; set; } = 0xFFFFFFFF;

        [JsonPropertyName("cutInType_")]
        public uint CutInType { get; set; } = 0;

    }
}

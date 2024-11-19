using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundPlayerRnoCondition : ConditionComponent
{
    [JsonPropertyName("checkRno_")]
    public int CheckRno { get; set; }

    [JsonPropertyName("objId_")]
    public int ObjId { get; set; }

    [JsonPropertyName("isTrigger_")]
    public bool IsTrigger { get; set; }

    [JsonPropertyName("isActionStartCheck_")]
    public bool IsActionStartCheck { get; set; }

    [JsonPropertyName("checkRnoHash_")]
    public uint CheckRnoHash { get; set; }

    [JsonPropertyName("rnoHashList_")]
    public BindingList<uint> RnoHashList { get; set; }

    [JsonPropertyName("checkType_")]
    public int CheckType { get; set; }

}

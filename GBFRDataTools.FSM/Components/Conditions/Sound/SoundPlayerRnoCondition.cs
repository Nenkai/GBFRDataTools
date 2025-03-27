using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundPlayerRnoCondition : ConditionComponent
{
    [JsonPropertyName("checkRno_")]
    public int CheckRno { get; set; } = -1;

    [JsonPropertyName("objId_")]
    [eObjId]
    public int ObjId { get; set; } = -1;

    [JsonPropertyName("isTrigger_")]
    public bool IsTrigger { get; set; } = false;

    [JsonPropertyName("isActionStartCheck_")]
    public bool IsActionStartCheck { get; set; } = false;

    [JsonPropertyName("checkRnoHash_")]
    public uint CheckRnoHash { get; set; } = 0;

    [JsonPropertyName("rnoHashList_")]
    public BindingList<uint> RnoHashList { get; set; } = [];

    [JsonPropertyName("checkType_")]
    public int CheckType { get; set; } = 0;

}

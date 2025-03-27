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

public class SoundPlayerActionIDCondition : ConditionComponent
{
    [JsonPropertyName("actionID_")]
    public int ActionID { get; set; } = 0;

    [JsonPropertyName("objId_")]
    [eObjId]
    public int ObjId { get; set; } = 0;

    [JsonPropertyName("isTrigger_")]
    public bool IsTrigger { get; set; } = false;

    [JsonPropertyName("isActionStartCheck_")]
    public bool IsActionStartCheck { get; set; } = false;

    [JsonPropertyName("chechActionIdList_")]
    public BindingList<int> ChechActionIdList { get; set; } = [];

    [JsonPropertyName("checkType_")]
    public int CheckType { get; set; } = 0;
}

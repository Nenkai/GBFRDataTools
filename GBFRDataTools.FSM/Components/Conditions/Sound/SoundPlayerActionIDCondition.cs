using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class SoundPlayerActionIDCondition : ConditionComponent
{
    [JsonPropertyName("actionID_")]
    public int ActionID { get; set; }

    [JsonPropertyName("objId_")]
    public int ObjId { get; set; }

    [JsonPropertyName("isTrigger_")]
    public bool IsTrigger { get; set; }

    [JsonPropertyName("isActionStartCheck_")]
    public bool IsActionStartCheck { get; set; }

    [JsonPropertyName("chechActionIdList_")]
    public BindingList<int> ChechActionIdList { get; set; }

    [JsonPropertyName("checkType_")]
    public int CheckType { get; set; }
}

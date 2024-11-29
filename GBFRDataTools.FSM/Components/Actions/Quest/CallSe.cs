using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallSe : QuestActionComponent
{
    [JsonPropertyName("wwiseIdName_")]
    public string WwiseIdName { get; set; } = string.Empty;

    [JsonPropertyName("changeState_")]
    public bool ChangeState { get; set; } = false;

    [JsonPropertyName("wwiseStateName_")]
    public string WwiseStateName { get; set; } = string.Empty;

    [JsonPropertyName("enablePos_")]
    public bool EnablePos { get; set; } = false;

    [JsonPropertyName("pos_")]
    public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;
}

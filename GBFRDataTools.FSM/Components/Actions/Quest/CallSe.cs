using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallSe : QuestActionComponent
{
    [JsonPropertyName("wwiseIdName_")]
    public string WwiseIdName { get; set; }

    [JsonPropertyName("changeState_")]
    public bool ChangeState { get; set; }

    [JsonPropertyName("wwiseStateName_")]
    public string WwiseStateName { get; set; }

    [JsonPropertyName("enablePos_")]
    public bool EnablePos { get; set; }

    [JsonPropertyName("pos_")]
    public cVec4 Pos { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}('{WwiseIdName}')";
        return str;
    }
}

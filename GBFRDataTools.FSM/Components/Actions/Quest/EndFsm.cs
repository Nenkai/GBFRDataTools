using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class EndFsm : QuestActionUseFsmBase
{
    [Obsolete("Not used by the game")]
    [JsonPropertyName("isMultiSelect_")]
    public bool IsMultiSelect { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("fsmDataInfos_")]
    public object FsmDataInfos { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}(no: {FsmDataNo}, progressHash: {FsmProgressHash})";
        return str;
    }
}

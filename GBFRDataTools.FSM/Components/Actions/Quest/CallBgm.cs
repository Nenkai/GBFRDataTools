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

public class CallBgm : QuestActionComponent
{
    [JsonPropertyName("wwiseIdName_")]
    public string WwiseIdName { get; set; }

    [JsonPropertyName("useBgmSetType_")]
    public bool UseBgmSetType { get; set; }

    [JsonPropertyName("bgmSetType_")]
    public int BgmSetType { get; set; }

    [JsonPropertyName("skipWhileSectionJump_")]
    public bool SkipWhileSectionJump { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}('{WwiseIdName}')";
        return str;
    }
}

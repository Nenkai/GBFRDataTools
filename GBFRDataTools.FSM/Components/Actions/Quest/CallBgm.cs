using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallBgm : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallBgm);

    [JsonPropertyName("wwiseIdName_")]
    public string WwiseIdName { get; set; } = string.Empty;

    [JsonPropertyName("useBgmSetType_")]
    public bool UseBgmSetType { get; set; } = false;

    [JsonPropertyName("bgmSetType_")]
    public BgmSetType BgmSetType { get; set; } = BgmSetType.Type0;

    [JsonPropertyName("skipWhileSectionJump_")]
    public bool SkipWhileSectionJump { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}('{WwiseIdName}')";
        return str;
    }
}

public enum BgmSetType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
    Type5 = 5,
    Type6 = 6,
    Type7 = 7,
    Type8 = 8,
    Type9 = 9,
    Type10 = 10,
    Type11 = 11,
    Type12 = 12,

}

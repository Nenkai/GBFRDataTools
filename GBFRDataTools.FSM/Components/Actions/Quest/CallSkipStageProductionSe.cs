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

public class CallSkipStageProductionSe : QuestActionComponent
{
    [JsonPropertyName("fadeType_")]
    public CallSkipStageProductionSeFadeType FadeType { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}

public enum CallSkipStageProductionSeFadeType : uint
{
    Type0 = 0,
    Type1 = 1,
}

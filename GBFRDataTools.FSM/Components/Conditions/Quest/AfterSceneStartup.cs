using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class AfterSceneStartup : QuestConditionComponent
{
    [JsonPropertyName("finishFadeIn_")]
    public bool FinishFadeIn { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}: \n";

        str += $"- FinishFadeIn: {FinishFadeIn}";

        return str;
    }
}

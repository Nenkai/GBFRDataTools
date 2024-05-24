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

public class ToggleQuestLight : QuestActionComponent
{
    [JsonPropertyName("isOn_")]
    public bool IsOn { get; set; }

    [JsonPropertyName("lightType_")]
    public int LightType { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}

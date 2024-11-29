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

public class SetFinishSlowEndSwitchCamera : QuestActionComponent
{
    [JsonPropertyName("endSwitchCamera_")]
    public bool EndSwitchCamera { get; set; } = true;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}

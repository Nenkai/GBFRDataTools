using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallFinishSlowEndSound : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallFinishSlowEndSound);

    [JsonPropertyName("playSe_")]
    public bool PlaySe { get; set; } = true;
}

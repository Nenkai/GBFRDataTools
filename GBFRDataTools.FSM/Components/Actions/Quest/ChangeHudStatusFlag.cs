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

public class ChangeHudStatusFlag : QuestActionComponent
{
    [JsonPropertyName("status_")]
    public uint Status { get; set; } = 0;

    [JsonPropertyName("priority_")]
    public int Priority { get; set; } = 0;
}

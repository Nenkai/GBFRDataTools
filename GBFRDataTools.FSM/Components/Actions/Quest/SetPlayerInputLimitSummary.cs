using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetPlayerInputLimitSummary : QuestActionComponent
{
    [JsonPropertyName("targetPlayers_")]
    public BindingList<int> TargetPlayers { get; set; } = [];

    [JsonPropertyName("actionIds_")]
    public BindingList<int> ActionIds { get; set; } = [];

    [JsonPropertyName("isLimit_")]
    public bool IsLimit { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}

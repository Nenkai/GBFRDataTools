﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class UseAbilityAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UseAbilityAction);

    [JsonPropertyName("playerIndex_")]
    public int PlayerIndex { get; set; } = 0;

    [JsonPropertyName("abilityTag_")]
    public string AbilityTag { get; set; } = string.Empty;

    [JsonPropertyName("isGuest_")]
    public bool IsGuest { get; set; } = false;
}

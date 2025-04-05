﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class ExistEntity : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ExistEntity);

    [JsonPropertyName("uniqueIdHash_")]
    public ulong UniqueIdHash { get; set; } = 0;

    [JsonPropertyName("checkPlayers_")]
    public bool CheckPlayers { get; set; } = false;
}

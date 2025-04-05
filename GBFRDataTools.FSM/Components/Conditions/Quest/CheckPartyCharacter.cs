using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckPartyCharacter : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckPartyCharacter);

    [JsonPropertyName("objId_")]
    [eObjId]
    public int ObjId { get; set; } = 0;

    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; } = 0;

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; } = string.Empty;
}

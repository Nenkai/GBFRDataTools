using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckEntryCharacter : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckEntryCharacter);

    [JsonPropertyName("characterID_")]
    public uint CharacterID { get; set; } = 0;
}

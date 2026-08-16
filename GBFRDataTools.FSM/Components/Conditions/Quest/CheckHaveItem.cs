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
public class CheckHaveItem : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckHaveItem);

    [JsonPropertyName("itemId_")]
    public uint ItemId { get; set; } = 0x887AE0B0; // Hash("");
}

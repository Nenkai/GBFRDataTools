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

namespace GBFRDataTools.FSM.Components.Actions.Quest.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AddSummonStone : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddSummonStone);

    [JsonPropertyName("summonMasterId_")]
    public string SummonMasterId { get; set; } // cyan::inplace_string<64>

    [JsonPropertyName("equipImmediately_")]
    public bool EquipImmediately { get; set; } = true;

    [JsonPropertyName("slotNo_")]
    public int SlotNo { get; set; } = 0;
}

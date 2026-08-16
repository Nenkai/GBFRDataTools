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

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetCollectionQuestBonusInfo : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetCollectionQuestBonusInfo);

    [JsonPropertyName("bonusTreasureUUIDs_")]
    public /*cy::PlacementInfo::Values*/ BindingList<ulong> BonusTreasureUUIDs { get; set; } = [];

    [JsonPropertyName("dialogIds_")]
    public BindingList<string> DialogIds { get; set; } = []; // std::vector<cyan::inplace_string<64>>

    [JsonPropertyName("requiredCounts_")]
    public BindingList<int> RequiredCounts { get; set; } = []; // std::vector<int>
}

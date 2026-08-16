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
public class CheckLinkedRewards : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckLinkedRewards);

    [JsonPropertyName("rewardType_")]
    [Description("Split into groups: 0-3, 4-8, 9, 10, 11")]
    public byte RewardType { get; set; } = 0;

    [JsonPropertyName("isReceived_")]
    public bool IsReceived { get; set; } = false;
}

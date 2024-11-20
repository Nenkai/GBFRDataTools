using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[Description("Starts a new phase section.")]
public class BeginSection : QuestActionComponent
{
    [JsonPropertyName("name_")]
    public string Name { get; set; }

    [JsonPropertyName("label_")]
    public string Label { get; set; }

    [JsonPropertyName("phaseNo_")]
    public uint PhaseNo { get; set; }

    [JsonPropertyName("subPhaseNo_")]
    public uint SubPhaseNo { get; set; }

    [JsonPropertyName("uniqueIdHash_")]
    public ulong UniqueIdHash { get; set; }

    [JsonPropertyName("controllers_")]
    public Controllers<UniqueId> Controllers { get; set; }

    [JsonPropertyName("isQuestStartSection_")]
    public bool IsQuestStartSection { get; set; }

    [JsonPropertyName("isSpawnVyrn_")]
    public bool IsSpawnVyrn { get; set; }

    [JsonPropertyName("eraseVyrnPhone_")]
    public bool EraseVyrnPhone { get; set; }

    [JsonPropertyName("isFullParty_")]
    public bool IsFullParty { get; set; }

    [JsonPropertyName("partyCharaType_")]
    public BindingList<int> PartyCharaType { get; set; }

    [JsonPropertyName("isReturnSection_")]
    public bool IsReturnSection { get; set; }

    [JsonPropertyName("isRetrySection_")]
    public bool IsRetrySection { get; set; }

    [JsonPropertyName("isRetrySectionKeep_")]
    public bool IsRetrySectionKeep { get; set; }

    [JsonPropertyName("isAcceptQuestSection_")]
    public bool IsAcceptQuestSection { get; set; }

    [JsonPropertyName("isItemReset_")]
    public bool IsItemReset { get; set; }

    [JsonPropertyName("isSpArtsReset_")]
    public bool IsSpArtsReset { get; set; }

    [JsonPropertyName("npcUniqueIdHash_")]
    public BindingList<ulong> NpcUniqueIdHash { get; set; }

    [JsonPropertyName("isSectionJumpFadeIn_")]
    public bool IsSectionJumpFadeIn { get; set; }

    [JsonPropertyName("npcPositionGroupUuidHash_")]
    public ulong NpcPositionGroupUuidHash { get; set; }

    [JsonPropertyName("questCrossCheckPointState_")]
    public int QuestCrossCheckPointState { get; set; } // Offset 0x200, 0x08:0, 0x38:4

    public override string ToString()
    {
        string str = $"{ComponentName}(phaseNo: p{PhaseNo:X3}, subPhaseNo: {PhaseNo:X3}, ...)";
        return str;
    }
}



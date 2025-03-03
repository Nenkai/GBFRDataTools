using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.ComponentModel.DataAnnotations;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[Description("Starts a new phase section.")]
public class BeginSection : QuestActionComponent
{
    [JsonPropertyName("name_")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("label_")]
    public string Label { get; set; } = string.Empty;

    [JsonPropertyName("phaseNo_")]
    public uint PhaseNo { get; set; } = 0;

    [JsonPropertyName("subPhaseNo_")]
    public uint SubPhaseNo { get; set; } = 0;

    [JsonPropertyName("uniqueIdHash_")]
    public ulong UniqueIdHash { get; set; } = 0;

    [JsonPropertyName("controllers_")]
    public Controllers<UniqueId> Controllers { get; set; }

    [JsonPropertyName("isQuestStartSection_")]
    public bool IsQuestStartSection { get; set; } = false;

    [JsonPropertyName("isSpawnVyrn_")]
    public bool IsSpawnVyrn { get; set; } = true;

    [JsonPropertyName("eraseVyrnPhone_")]
    public bool EraseVyrnPhone { get; set; } = false;

    [JsonPropertyName("isFullParty_")]
    public bool IsFullParty { get; set; } = false;

    [JsonPropertyName("partyCharaType_")]
    [Editable(false)]
    public BindingList<EPartyCharaType> PartyCharaType { get; set; } = [.. Enumerable.Repeat(EPartyCharaType.Type0, 4).ToList()];

    [JsonPropertyName("isReturnSection_")]
    public bool IsReturnSection { get; set; } = true;

    [JsonPropertyName("isRetrySection_")]
    public bool IsRetrySection { get; set; } = false;

    [JsonPropertyName("isRetrySectionKeep_")]
    public bool IsRetrySectionKeep { get; set; } = false;

    [JsonPropertyName("isAcceptQuestSection_")]
    public bool IsAcceptQuestSection { get; set; } = false;

    [JsonPropertyName("isItemReset_")]
    public bool IsItemReset { get; set; } = false;

    [JsonPropertyName("isSpArtsReset_")]
    public bool IsSpArtsReset { get; set; } = false;

    [JsonPropertyName("npcUniqueIdHash_")]
    public BindingList<ulong> NpcUniqueIdHash { get; set; } = [];

    [JsonPropertyName("isSectionJumpFadeIn_")]
    public bool IsSectionJumpFadeIn { get; set; } = true;

    [JsonPropertyName("npcPositionGroupUuidHash_")]
    public ulong NpcPositionGroupUuidHash { get; set; } = 0;

    [JsonPropertyName("questCrossCheckPointState_")]
    public int QuestCrossCheckPointState { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}(phaseNo: p{PhaseNo:X3}, subPhaseNo: {PhaseNo:X3}, ...)";
        return str;
    }

    public enum EPartyCharaType : int
    {
        Type0 = 0,
        Type1_NPC = 1,
        Type2_Player = 2,
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallVanishEventVoice : QuestActionComponent
{
    [JsonPropertyName("vanishCharacterIndexParameterHash_")]
    public uint VanishCharacterIndexParameterHash { get; set; }

    [JsonPropertyName("vanishCharacterIndexParameterName_")]
    public string VanishCharacterIndexParameterName { get; set; }

    [JsonPropertyName("vanishNoParameterHash_")]
    public uint VanishNoParameterHash { get; set; }

    [JsonPropertyName("vanishNoParameterName_")]
    public string VanishNoParameterName { get; set; }

    [JsonPropertyName("idOfPlayingVoiceParameterName_")]
    public string IdOfPlayingVoiceParameterName { get; set; }

    [JsonPropertyName("idOfPlayingVoiceParameterHash_")]
    public uint IdOfPlayingVoiceParameterHash { get; set; }

    [JsonPropertyName("reactionVoices_")]
    public BindingList<string> ReactionVoices { get; set; }

    [JsonPropertyName("reactionVoiceHashes_")]
    public BindingList<uint> ReactionVoiceHashes { get; set; }

    [JsonPropertyName("dedicatedReactions_")]
    public BindingList<DedicatedReaction> DedicatedReactions { get; set; }

    public class DedicatedReaction
    {
        [JsonPropertyName("characterId_")]
        public uint CharacterId { get; set; }

        [JsonPropertyName("voices_")]
        public BindingList<string> Voices { get; set; }

        [JsonPropertyName("voiceHashes_")]
        public BindingList<uint> VoiceHashes { get; set; }
    }
}

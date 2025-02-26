using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallVanishEventVoice : QuestActionComponent
{
    /// <summary>
    /// CRC32
    /// </summary>
    [JsonPropertyName("vanishCharacterIndexParameterHash_")]
    public uint VanishCharacterIndexParameterHash { get; set; } = Crc32.HashToUInt32("vanish_party_character_index"u8);

    [JsonPropertyName("vanishCharacterIndexParameterName_")]
    public string VanishCharacterIndexParameterName { get; set; } = "vanish_party_character_index";

    /// <summary>
    /// CRC32
    /// </summary>
    [JsonPropertyName("vanishNoParameterHash_")]
    public uint VanishNoParameterHash { get; set; } = Crc32.HashToUInt32("vanish_no"u8);

    [JsonPropertyName("vanishNoParameterName_")]
    public string VanishNoParameterName { get; set; } = "vanish_no";

    [JsonPropertyName("idOfPlayingVoiceParameterName_")]
    public string IdOfPlayingVoiceParameterName { get; set; } = "id_of_playing_vanish_event_voice";

    /// <summary>
    /// CRC32
    /// </summary>
    [JsonPropertyName("idOfPlayingVoiceParameterHash_")]
    public uint IdOfPlayingVoiceParameterHash { get; set; } = Crc32.HashToUInt32("id_of_playing_vanish_event_voice"u8);

    [JsonPropertyName("reactionVoices_")]
    public BindingList<string> ReactionVoices { get; set; } = [];

    [JsonPropertyName("reactionVoiceHashes_")]
    public BindingList<uint> ReactionVoiceHashes { get; set; } = [];

    [JsonPropertyName("dedicatedReactions_")]
    public BindingList<DedicatedReaction> DedicatedReactions { get; set; } = [];

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DedicatedReaction
    {
        [JsonPropertyName("characterId_")]
        public uint CharacterId { get; set; } = 0;

        [JsonPropertyName("voices_")]
        public BindingList<string> Voices { get; set; } = [];

        [JsonPropertyName("voiceHashes_")]
        public BindingList<uint> VoiceHashes { get; set; } = [];
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerLinkAttackVoiceParameterFile
{
    [JsonPropertyName(nameof(PlayerLinkAttackVoiceParameter))]
    public PlayerLinkAttackVoiceParameter PlayerLinkAttackVoiceParameter { get; set; }

    public static PlayerLinkAttackVoiceParameterFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        PlayerLinkAttackVoiceParameterFile paramFile = JsonSerializer.Deserialize<PlayerLinkAttackVoiceParameterFile>(text, DefaultJsonSerializerOptions.InstanceForRead);
        return paramFile;
    }
}

public class PlayerLinkAttackVoiceParameter
{
    [JsonPropertyName("selectVersatileVoice_MainStory_")]
    public float SelectVersatileVoice_MainStory { get; set; }

    [JsonPropertyName("selectPairsUniqueVoice_MainStory_")]
    public float SelectPairsUniqueVoice_MainStory { get; set; }

    [JsonPropertyName("selectVersatileVoice_Quest_")]
    public float SelectVersatileVoice_Quest { get; set; }

    [JsonPropertyName("largeDamageVoiceIntervalSec_")]
    public float LargeDamageVoiceIntervalSec { get; set; }

    [JsonPropertyName("largeDamageVoiceTriggerHpRate_")]
    public float LargeDamageVoiceTriggerHpRate { get; set; }

    [JsonPropertyName("dieVoiceIntervalSec_")]
    public float DieVoiceIntervalSec { get; set; }
}
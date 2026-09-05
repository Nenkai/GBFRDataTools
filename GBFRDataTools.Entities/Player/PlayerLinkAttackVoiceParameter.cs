using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Player;

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

    [JsonPropertyName("voiceWaitParam_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public BindingList<ChainBurstAfterVoiceWaitSecParam> VoiceWaitParam { get; set; } = [.. Enumerable.Repeat(new ChainBurstAfterVoiceWaitSecParam(), 3)]; // std::array<PlayerLinkAttackVoiceParameter::ChainBurstAfterVoiceWaitSecParam, 3>

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ChainBurstAfterVoiceWaitSecParam /* PlayerLinkAttackVoiceParameter::ChainBurstAfterVoiceWaitSecParam */
    {
        [JsonPropertyName("fire_")]
        public float Fire { get; set; }
    
        [JsonPropertyName("water_")]
        public float Water { get; set; }
    
        [JsonPropertyName("wind_")]
        public float Wind { get; set; }
    
        [JsonPropertyName("earth_")]
        public float Earth { get; set; }
    
        [JsonPropertyName("light_")]
        public float Light { get; set; }
    
        [JsonPropertyName("dark_")]
        public float Dark { get; set; }
    }
}
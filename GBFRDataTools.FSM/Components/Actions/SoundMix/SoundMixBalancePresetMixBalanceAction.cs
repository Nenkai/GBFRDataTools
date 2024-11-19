using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalancePresetMixBalanceAction : ActionComponent
{
    [JsonPropertyName("presetNo_")]
    public int PresetNo { get; set; }

    [JsonPropertyName("configList_")]
    public BindingList<Config> ConfigList { get; set; }

    [JsonPropertyName("divideByEventsConfigList_")]
    public BindingList<PresetParameter> DivideByEventsConfigList { get; set; }

    public class Config // SoundMixBalancePresetMixBalanceAction::Config
    {
        [JsonPropertyName("isDisable_")]
        public bool IsDisable { get; set; }

        [JsonPropertyName("triggerCondition_")]
        public MixBalanceControlCondition TriggerCondition { get; set; }

        [JsonPropertyName("controlCondition_")]
        public MixBalanceControlCondition ControlCondition { get; set; }

        [JsonPropertyName("isUseEventVolume_")]
        public bool IsUseEventVolume { get; set; }

        [JsonPropertyName("eventVolumeControlConfig_")]
        public MixBalanceEventVolumeControlConfig EventVolumeControlConfig { get; set; }

        [JsonPropertyName("isUseEventFilter_")]
        public bool IsUseEventFilter { get; set; }

        [JsonPropertyName("eventFilterControlConfig_")]
        public MixBalanceEventFilterControlConfig EventFilterControlConfig { get; set; }

        [JsonPropertyName("isUseBusLoudness_")]
        public bool IsUseBusLoudness { get; set; }

        [JsonPropertyName("busLoudnessControlConfig_")]
        public MixBalanceBusLoudnessControlConfig BusLoudnessControlConfig { get; set; }
    }

    public class PresetParameter // Sound::MixBalanceModule::DivideByEvents::PresetParameter
    {
        [JsonPropertyName("isDisable_")]
        public bool IsDisable { get; set; }

        [JsonPropertyName("triggerAndControl_")]
        public BindingList<MixBalanceControlCondition> TriggerAndControl { get; set; }

        [JsonPropertyName("config_")]
        public MixBalanceDivideVolumeControlConfig Config { get; set; }
    }

}

public class MixBalanceControlCondition // Sound::MixBalanceControlCondition
{
    [JsonPropertyName("busID_")]
    public uint BusID { get; set; }

    [JsonPropertyName("eventID_")]
    public uint EventID { get; set; }

    [JsonPropertyName("passEventCategory_")]
    public uint PassEventCategory { get; set; }

    [JsonPropertyName("rejectEventCategory_")]
    public uint RejectEventCategory { get; set; }
}

public class MixBalanceEventVolumeControlConfig // Sound::MixBalanceEventVolumeControlConfig
{
    [JsonPropertyName("waitTimeMs_")]
    public uint WaitTimeMs { get; set; }

    [JsonPropertyName("cutTimeMs_")]
    public uint CutTimeMs { get; set; }

    [JsonPropertyName("holdTimeMs_")]
    public uint HoldTimeMs { get; set; }

    [JsonPropertyName("releaseTimeMs_")]
    public uint ReleaseTimeMs { get; set; }

    [JsonPropertyName("thresholdTimeMs_")]
    public uint ThresholdTimeMs { get; set; }

    [JsonPropertyName("controlRatioMax_")]
    public float ControlRatioMax { get; set; }

    [JsonPropertyName("thresholdDistanceVolume_")]
    public float ThresholdDistanceVolume { get; set; }

    [JsonPropertyName("isCheckCharacterType_")]
    public bool IsCheckCharacterType { get; set; }

    [JsonPropertyName("characterType_")]
    public uint CharacterType { get; set; }
}

public class MixBalanceEventFilterControlConfig // Sound::MixBalanceEventFilterControlConfig
{
    [JsonPropertyName("durationTimeMs_")]
    public uint DurationTimeMs { get; set; }

    [JsonPropertyName("RTPCMax_")]
    public float RTPCMax { get; set; }

    [JsonPropertyName("thresholdDistanceVolume_")]
    public float ThresholdDistanceVolume { get; set; }

    [JsonPropertyName("RTPCName_")]
    public string RTPCName { get; set; }

    [JsonPropertyName("isCheckCharacterType_")]
    public bool IsCheckCharacterType { get; set; }

    [JsonPropertyName("characterType_")]
    public uint CharacterType { get; set; }
}

public class MixBalanceBusLoudnessControlConfig // Sound::MixBalanceBusLoudnessControlConfig
{
    [JsonPropertyName("durationTimeMs_")]
    public uint DurationTimeMs { get; set; }

    [JsonPropertyName("loudnessThreshold_")]
    public float LoudnessThreshold { get; set; }

    [JsonPropertyName("controlRatio_")]
    public float ControlRatio { get; set; }
}

public class MixBalanceDivideVolumeControlConfig // Sound::MixBalanceDivideVolumeControlConfig
{
    [JsonPropertyName("groupId_")]
    public uint GroupId { get; set; }

    [JsonPropertyName("thresholdTimeMs_")]
    public uint ThresholdTimeMs { get; set; }

    [JsonPropertyName("volumeControlRate_")]
    public float VolumeControlRate { get; set; }

    [JsonPropertyName("thresholdDistanceVolume_")]
    public float ThresholdDistanceVolume { get; set; }

    [JsonPropertyName("isCheckCharacterType_")]
    public bool IsCheckCharacterType { get; set; }

    [JsonPropertyName("characterType_")]
    public uint CharacterType { get; set; }
}
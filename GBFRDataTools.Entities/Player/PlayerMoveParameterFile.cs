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

public class PlayerMoveParameterFile
{
    [JsonPropertyName(nameof(PlayerMoveParameter))]
    public PlayerMoveParameter PlayerMoveParameter { get; set; }

    public static PlayerMoveParameterFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(text);

        PlayerMoveParameterFile paramFile = JsonSerializer.Deserialize<PlayerMoveParameterFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class PlayerMoveParameter
{
    [JsonPropertyName("sliderRotationRate_")]
    public float SliderRotationRate { get; set; }

    [JsonPropertyName("sliderStartEnableDot_")]
    public float SliderStartEnableDot { get; set; }

    [JsonPropertyName("sliderAccelerationDot_")]
    public float SliderAccelerationDot { get; set; }

    [JsonPropertyName("sliderEndSpeed_")]
    public float SliderEndSpeed { get; set; }

    [JsonPropertyName("slider_Stand_JumpCheckWidth_")]
    public float Slider_Stand_JumpCheckWidth { get; set; }

    [JsonPropertyName("slider_Stand_JumpCheckHeight_")]
    public float Slider_Stand_JumpCheckHeight { get; set; }

    [JsonPropertyName("sliderSpeedMax_")]
    public float SliderSpeedMax { get; set; }

    [JsonPropertyName("sliderAccel_")]
    public float SliderAccel { get; set; }

    [JsonPropertyName("sliderDeceleration_")]
    public float SliderDeceleration { get; set; }

    [JsonPropertyName("avoidCountResetTime_")]
    public float AvoidCountResetTime { get; set; }

    [JsonPropertyName("avoidCountMax_")]
    public int AvoidCountMax { get; set; }

    [JsonPropertyName("justAvoidFrame_")]
    public int JustAvoidFrame { get; set; }

    [JsonPropertyName("justAvoidSucces_InvinsibleTime_")]
    public float JustAvoidSucces_InvinsibleTime { get; set; }

    [JsonPropertyName("skillAvoidMovementRate_")]
    public float SkillAvoidMovementRate { get; set; }

    [JsonPropertyName("passiveInvinsibleTime_")]
    public float PassiveInvinsibleTime { get; set; }

    [JsonPropertyName("downInvisibleTime_")]
    public float DownInvisibleTime { get; set; }

    [JsonPropertyName("hormingMoveRateMin_")]
    public float HormingMoveRateMin { get; set; }

    [JsonPropertyName("hormingMoveRateMax_")]
    public float HormingMoveRateMax { get; set; }

    [JsonPropertyName("sliderBaseSpeedRate_Stand_")]
    public float SliderBaseSpeedRate_Stand { get; set; }

    [JsonPropertyName("sliderBaseSpeedRate_Hip_")]
    public float SliderBaseSpeedRate_Hip { get; set; }

    [JsonPropertyName("sliderSpeedMax_WindDash_")]
    public float SliderSpeedMax_WindDash { get; set; }

    [JsonPropertyName("sliderSpeedSubRate_")]
    public float SliderSpeedSubRate { get; set; }

    [JsonPropertyName("hipSliderSpeedListNum_")]
    public int HipSliderSpeedListNum { get; set; }

    /// <summary>
    /// 8 elements max. PlayerMoveParameter::HipSliderSpeedParam
    /// </summary>
    [JsonPropertyName("hipSliderSpeedList_")]
    public BindingList<HipSliderSpeedParam> HipSliderSpeedList { get; set; }

    [JsonPropertyName("jumpAssistFrame_")]
    public int JumpAssistFrame { get; set; }

    [JsonPropertyName("isAutoDash_")]
    public bool IsAutoDash { get; set; }

    [JsonPropertyName("autoDashStartTime_")]
    public float AutoDashStartTime { get; set; }

    [JsonPropertyName("autoDashThreshold_")]
    public float AutoDashThreshold { get; set; }

    [JsonPropertyName("yCorrectionHeightLimit_")]
    public float YCorrectionHeightLimit { get; set; }

    [JsonPropertyName("assist2stRangeLimit_")]
    public float Assist2stRangeLimit { get; set; }
}

public class HipSliderSpeedParam
{
    [JsonPropertyName("questId_")]
    public int QuestId { get; set; }

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; }
}

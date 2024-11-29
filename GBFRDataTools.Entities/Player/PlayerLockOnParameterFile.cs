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

public class PlayerLockOnParameterFile
{
    [JsonPropertyName(nameof(PlayerLockOnParameter))]
    public PlayerLockOnParameter PlayerLockOnParameter { get; set; }

    public static PlayerLockOnParameterFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        PlayerLockOnParameterFile paramFile = JsonSerializer.Deserialize<PlayerLockOnParameterFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class PlayerLockOnParameter
{
    [JsonPropertyName("searchTargetInfoList_")]
    public BindingList<SearchLockOnInfo> SearchTargetInfoList { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleNear_")]
    public float LockonCameraOffsetAngleNear { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleFar_")]
    public float LockonCameraOffsetAngleFar { get; set; }

    [JsonPropertyName("lockonCameraOffsetCheckDistNear_")]
    public float LockonCameraOffsetCheckDistNear { get; set; }

    [JsonPropertyName("lockonCameraOffsetCheckDistFar_")]
    public float LockonCameraOffsetCheckDistFar { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleOffsetX_")]
    [Obsolete("Unused by the game")]
    public float LockonCameraOffsetAngleOffsetX { get; set; }

}

// PlayerLockOnParameter::SearchLockOnInfo
public class SearchLockOnInfo
{
    [JsonPropertyName("maxLen")]
    public float MaxLen { get; set; }

    [JsonPropertyName("maxRot")]
    public float MaxRot { get; set; }

    [JsonPropertyName("height")]
    public float Height { get; set; }

    [JsonPropertyName("isLockOnMaxRangeSetting")]
    public bool IsLockOnMaxRangeSetting { get; set; }

    [JsonPropertyName("isBreakObjectCheck")]
    public bool IsBreakObjectCheck { get; set; }

    [JsonPropertyName("isEnableStickInput")]
    public bool IsEnableStickInput { get; set; }

    [JsonPropertyName("isForceEnableStickInput")]
    public bool IsForceEnableStickInput { get; set; }
}

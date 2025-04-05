using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerAutoHomingParameterFile
{
    [JsonPropertyName(nameof(PlayerAutoHomingParameter))]
    public PlayerAutoHomingParameter PlayerAutoHomingParameter { get; set; }

    public static PlayerAutoHomingParameterFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        PlayerAutoHomingParameterFile paramFile = JsonSerializer.Deserialize<PlayerAutoHomingParameterFile>(text, DefaultJsonSerializerOptions.InstanceForRead);
        return paramFile;
    }
}

public class PlayerAutoHomingParameter
{
    [JsonPropertyName("nearDistanceAutoHomingParam_")]
    public PlayerLockOnParameter NearDistanceAutoHomingParam { get; set; }

    [JsonPropertyName("farDistanceAutoHomingParam_")]
    public PlayerLockOnParameter FarDistanceAutoHomingParam { get; set; }

    [JsonPropertyName("spArtsAutoHomingParam_")]
    public PlayerLockOnParameter SpArtsAutoHomingParam { get; set; }

    [JsonPropertyName("shotAutoHomingParam_")]
    public PlayerLockOnParameter ShotAutoHomingParam { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleNear_")]
    public float LockonCameraOffsetAngleNear { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleFar_")]
    public float LockonCameraOffsetAngleFar { get; set; }

    [JsonPropertyName("lockonCameraOffsetCheckDistNear_")]
    public float LockonCameraOffsetCheckDistNear { get; set; }

    [JsonPropertyName("lockonCameraOffsetCheckDistFar_")]
    public float LockonCameraOffsetCheckDistFar { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleOffsetX_Near_")]
    public float LockonCameraOffsetAngleOffsetX_Near { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleOffsetX_Far_")]
    public float LockonCameraOffsetAngleOffsetX_Far { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleXCheckDistNear_")]
    public float LockonCameraOffsetAngleXCheckDistNear { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleXCheckDistFar_")]
    public float LockonCameraOffsetAngleXCheckDistFar { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleXCheckCameraDistNear_")]
    public float LockonCameraOffsetAngleXCheckCameraDistNear { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleXCheckCameraDistFar_")]
    public float LockonCameraOffsetAngleXCheckCameraDistFar { get; set; }

    [JsonPropertyName("lockonCameraOffsetAngleOffsetX_Far_CameraFar_")]
    public float LockonCameraOffsetAngleOffsetX_Far_CameraFar { get; set; }
}
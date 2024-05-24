using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetThreePointRailCamera : QuestActionComponent
{
    [JsonPropertyName("cameraRailObjectId_")]
    public ulong CameraRailObjectId { get; set; }

    [JsonPropertyName("cameraRailRootId_")]
    public ulong CameraRailRootId { get; set; }

    [JsonPropertyName("watchRailObjectId_")]
    public ulong WatchRailObjectId { get; set; }

    [JsonPropertyName("watchRailRootId_")]
    public ulong WatchRailRootId { get; set; }

    [JsonPropertyName("progressRailObjectId_")]
    public ulong ProgressRailObjectId { get; set; }

    [JsonPropertyName("progressRailRootId_")]
    public ulong ProgressRailRootId { get; set; }

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; }

    [JsonPropertyName("maxSpeedRate_")]
    public float MaxSpeedRate { get; set; }

    [JsonPropertyName("enableRailCamera_")]
    public bool EnableRailCamera { get; set; }

    [JsonPropertyName("invalidCameraCollision_")]
    public bool InvalidCameraCollision { get; set; }

    [JsonPropertyName("interpolationSecond_")]
    public float InterpolationSecond { get; set; }

    [JsonPropertyName("limitRotY_")]
    public float LimitRotY { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}

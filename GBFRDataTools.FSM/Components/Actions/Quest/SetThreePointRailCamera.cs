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
    public ulong CameraRailObjectId { get; set; } = 0;

    [JsonPropertyName("cameraRailRootId_")]
    public ulong CameraRailRootId { get; set; } = 0;

    [JsonPropertyName("watchRailObjectId_")]
    public ulong WatchRailObjectId { get; set; } = 0;

    [JsonPropertyName("watchRailRootId_")]
    public ulong WatchRailRootId { get; set; } = 0;

    [JsonPropertyName("progressRailObjectId_")]
    public ulong ProgressRailObjectId { get; set; } = 0;

    [JsonPropertyName("progressRailRootId_")]
    public ulong ProgressRailRootId { get; set; } = 0;

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1.0f;

    [JsonPropertyName("maxSpeedRate_")]
    public float MaxSpeedRate { get; set; } = 1.0f;

    [JsonPropertyName("enableRailCamera_")]
    public bool EnableRailCamera { get; set; } = false;

    [JsonPropertyName("invalidCameraCollision_")]
    public bool InvalidCameraCollision { get; set; } = false;

    [JsonPropertyName("interpolationSecond_")]
    public float InterpolationSecond { get; set; } = 0.0f;

    [JsonPropertyName("limitRotY_")]
    public float LimitRotY { get; set; } = 0.0f;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}

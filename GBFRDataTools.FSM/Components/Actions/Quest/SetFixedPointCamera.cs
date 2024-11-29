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

public class SetFixedPointCamera : QuestActionComponent
{
    [JsonPropertyName("positionObjectId_")]
    public ulong PositionObjectId { get; set; } = 0;

    [JsonPropertyName("positionRootId_")]
    public ulong PositionRootId { get; set; } = 0;

    [JsonPropertyName("targetObjectId_")]
    public ulong TargetObjectId { get; set; } = 0;

    [JsonPropertyName("targetRootId_")]
    public ulong TargetRootId { get; set; } = 0;

    [JsonPropertyName("positionIsPoint_")]
    public bool PositionIsPoint { get; set; } = true;

    [JsonPropertyName("targetIsPoint_")]
    public bool TargetIsPoint { get; set; } = true;

    [JsonPropertyName("positionPartsNo_")]
    public int PositionPartsNo { get; set; } = -1;

    [JsonPropertyName("targetPartsNo_")]
    public int TargetPartsNo { get; set; } = -1;

    [JsonPropertyName("sec_")]
    public float Sec { get; set; } = 5.0f;

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 0.01f;

    [JsonPropertyName("useHeightDiff_")]
    public bool UseHeightDiff { get; set; } = false;

    [JsonPropertyName("keepCameraAngle_")]
    public bool KeepCameraAngle { get; set; } = false;

    [JsonPropertyName("useNowCameraPos_")]
    public bool UseNowCameraPos { get; set; } = false;

    [JsonPropertyName("useNowCameraTarget_")]
    public bool UseNowCameraTarget { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}

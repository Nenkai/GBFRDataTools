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
    public ulong PositionObjectId { get; set; }

    [JsonPropertyName("positionRootId_")]
    public ulong PositionRootId { get; set; }

    [JsonPropertyName("targetObjectId_")]
    public ulong TargetObjectId { get; set; }

    [JsonPropertyName("targetRootId_")]
    public ulong TargetRootId { get; set; }

    [JsonPropertyName("positionIsPoint_")]
    public bool PositionIsPoint { get; set; }

    [JsonPropertyName("targetIsPoint_")]
    public bool TargetIsPoint { get; set; }

    [JsonPropertyName("positionPartsNo_")]
    public int PositionPartsNo { get; set; }

    [JsonPropertyName("targetPartsNo_")]
    public int TargetPartsNo { get; set; }

    [JsonPropertyName("sec_")]
    public float Sec { get; set; }

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; }

    [JsonPropertyName("useHeightDiff_")]
    public bool UseHeightDiff { get; set; }

    [JsonPropertyName("keepCameraAngle_")]
    public bool KeepCameraAngle { get; set; }

    [JsonPropertyName("useNowCameraPos_")]
    public bool UseNowCameraPos { get; set; }

    [JsonPropertyName("useNowCameraTarget_")]
    public bool UseNowCameraTarget { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}

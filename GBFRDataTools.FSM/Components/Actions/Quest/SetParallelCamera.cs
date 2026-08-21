using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetParallelCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetParallelCamera);

    [JsonPropertyName("startObjectId_")]
    public ulong StartObjectId { get; set; } 

    [JsonPropertyName("startRootId_")]
    public ulong StartRootId { get; set; } 

    [JsonPropertyName("startPartsNo_")]
    public int StartPartsNo { get; set; } = 0; 

    [JsonPropertyName("isStartTargetEntity_")]
    public bool IsStartTargetEntity { get; set; } = false; 

    [JsonPropertyName("endObjectId_")]
    public ulong EndObjectId { get; set; } 

    [JsonPropertyName("endRootId_")]
    public ulong EndRootId { get; set; } 

    [JsonPropertyName("endPartsNo_")]
    public int EndPartsNo { get; set; } = 0; 

    [JsonPropertyName("isEndTargetEntity_")]
    public bool IsEndTargetEntity { get; set; } = false; 

    [JsonPropertyName("isDisableControlCam_")]
    public bool IsDisableControlCam { get; set; } = true; 

    [JsonPropertyName("enableCancelByCamInput_")]
    public bool EnableCancelByCamInput { get; set; } = false; 

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 0f; 

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0f; 

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 0f; 

    [JsonPropertyName("viewStartPos_")]
    public Vector3 ViewStartPos { get; set; } = Vector3.Zero; 
}

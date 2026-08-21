using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static System.Collections.Specialized.BitVector32;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetRotateCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetRotateCamera);

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } 

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } 

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = 0; 

    [JsonPropertyName("isTargetEntity_")]
    public bool IsTargetEntity { get; set; } = false; 

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

    [JsonPropertyName("rotate_")]
    public float Rotate { get; set; } = 0f; 

    [JsonPropertyName("viewStartPos_")]
    public Vector3 ViewStartPos { get; set; } = new Vector3(0f, 0f, 0f);

    public override string? GetCaption()
    {
        return $"ObjectId: {ObjectId}";
    }
}

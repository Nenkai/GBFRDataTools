using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetRotateCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetRotateCamera);

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } // Offset 0x48

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } // Offset 0x50

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = 0; // Offset 0x58

    [JsonPropertyName("isTargetEntity_")]
    public bool IsTargetEntity { get; set; } = false; // Offset 0x5C

    [JsonPropertyName("isDisableControlCam_")]
    public bool IsDisableControlCam { get; set; } = true; // Offset 0x5D

    [JsonPropertyName("enableCancelByCamInput_")]
    public bool EnableCancelByCamInput { get; set; } = false; // Offset 0x5E

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 0f; // Offset 0x60

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0f; // Offset 0x64

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 0f; // Offset 0x68

    [JsonPropertyName("rotate_")]
    public float Rotate { get; set; } = 0f; // Offset 0x6C

    [JsonPropertyName("viewStartPos_")]
    public Vector3 ViewStartPos { get; set; } = new Vector3(0f, 0f, 0f); // Offset 0x70

    public SetRotateCamera()
    {
    }
}

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
    public ulong StartObjectId { get; set; } // Offset 0x48

    [JsonPropertyName("startRootId_")]
    public ulong StartRootId { get; set; } // Offset 0x50

    [JsonPropertyName("startPartsNo_")]
    public int StartPartsNo { get; set; } = 0; // Offset 0x58

    [JsonPropertyName("isStartTargetEntity_")]
    public bool IsStartTargetEntity { get; set; } = false; // Offset 0x5C

    [JsonPropertyName("endObjectId_")]
    public ulong EndObjectId { get; set; } // Offset 0x60

    [JsonPropertyName("endRootId_")]
    public ulong EndRootId { get; set; } // Offset 0x68

    [JsonPropertyName("endPartsNo_")]
    public int EndPartsNo { get; set; } = 0; // Offset 0x70

    [JsonPropertyName("isEndTargetEntity_")]
    public bool IsEndTargetEntity { get; set; } = false; // Offset 0x74

    [JsonPropertyName("isDisableControlCam_")]
    public bool IsDisableControlCam { get; set; } = true; // Offset 0x75

    [JsonPropertyName("enableCancelByCamInput_")]
    public bool EnableCancelByCamInput { get; set; } = false; // Offset 0x76

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 0f; // Offset 0x78

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0f; // Offset 0x7C

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 0f; // Offset 0x80

    [JsonPropertyName("viewStartPos_")]
    public Vector3 ViewStartPos { get; set; } = Vector3.Zero; // Offset 0x84

    public SetParallelCamera()
    {
    }
}

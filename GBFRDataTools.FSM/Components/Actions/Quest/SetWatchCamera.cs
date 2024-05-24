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

public class SetWatchCamera : QuestActionComponent
{
    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; }

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; }

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; }

    [JsonPropertyName("isTargetEntity_")]
    public bool IsTargetEntity { get; set; }

    [JsonPropertyName("isDisableControlCam_")]
    public bool IsDisableControlCam { get; set; }

    [JsonPropertyName("enableCancelByCamInput_")]
    public bool EnableCancelByCamInput { get; set; }

    [JsonPropertyName("moveRate_")]
    public cVec2 MoveRate { get; set; }

    [JsonPropertyName("moveWaitTime_")]
    public cVec2 MoveWaitTime { get; set; }

    [JsonPropertyName("moveMaxDeg_")]
    public cVec2 MoveMaxDeg { get; set; }

    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("camRate_")]
    public float CamRate { get; set; }

    [JsonPropertyName("camRateInterTime_")]
    public float CamRateInterTime { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}

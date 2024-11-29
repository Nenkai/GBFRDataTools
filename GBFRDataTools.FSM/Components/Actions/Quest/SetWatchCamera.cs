using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetWatchCamera : QuestActionComponent
{
    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } = 0;

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } = 0;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = 0;

    [JsonPropertyName("isTargetEntity_")]
    public bool IsTargetEntity { get; set; } = false;

    [JsonPropertyName("isDisableControlCam_")]
    public bool IsDisableControlCam { get; set; } = true;

    [JsonPropertyName("enableCancelByCamInput_")]
    public bool EnableCancelByCamInput { get; set; } = false;

    [JsonPropertyName("moveRate_")]
    public /* cVec2 */ Vector2 MoveRate { get; set; } = new Vector2(0.5f, 0.5f);

    [JsonPropertyName("moveWaitTime_")]
    public /* cVec2 */ Vector2 MoveWaitTime { get; set; } = Vector2.Zero;

    [JsonPropertyName("moveMaxDeg_")]
    public /* cVec2 */ Vector2 MoveMaxDeg { get; set; } = new Vector2(5.0f, 5.0f);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 2.0f;

    [JsonPropertyName("camRate_")]
    public float CamRate { get; set; } = -1.0f;

    [JsonPropertyName("camRateInterTime_")]
    public float CamRateInterTime { get; set; } = 1.0f;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}

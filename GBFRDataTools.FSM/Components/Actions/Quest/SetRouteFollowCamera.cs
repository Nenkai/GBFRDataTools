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

public class SetRouteFollowCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetRouteFollowCamera);

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } 

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } 

    [JsonPropertyName("speedRate_")]
    public Vector2 SpeedRate { get; set; } = new Vector2(1f, 1f); 

    [JsonPropertyName("enableCam_")]
    public bool EnableCam { get; set; } = false; 

    [JsonPropertyName("execIgnoreTerrainCorrection_")]
    public bool ExecIgnoreTerrainCorrection { get; set; } = false; 

    [JsonPropertyName("stopTime_")]
    public float StopTime { get; set; } = 3f; 

    [JsonPropertyName("stopInReverseRun_")]
    public bool StopInReverseRun { get; set; } = false;

    public override string? GetCaption()
    {
        return $"ObjectId: {ObjectId}";
    }
}

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
    public ulong ObjectId { get; set; } // Offset 0x48

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } // Offset 0x50

    [JsonPropertyName("speedRate_")]
    public Vector2 SpeedRate { get; set; } = new Vector2(1f, 1f); // Offset 0x5C

    [JsonPropertyName("enableCam_")]
    public bool EnableCam { get; set; } = false; // Offset 0x58

    [JsonPropertyName("execIgnoreTerrainCorrection_")]
    public bool ExecIgnoreTerrainCorrection { get; set; } = false; // Offset 0x64

    [JsonPropertyName("stopTime_")]
    public float StopTime { get; set; } = 3f; // Offset 0x68

    [JsonPropertyName("stopInReverseRun_")]
    public bool StopInReverseRun { get; set; } = false; // Offset 0x6C

    public SetRouteFollowCamera()
    {
    }
}

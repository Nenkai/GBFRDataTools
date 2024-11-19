using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001MoveToAction : ActionComponent
{
    [JsonPropertyName("movePassIndex_")]
    public int MovePassIndex { get; set; }

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; }

    [JsonPropertyName("motFrame_")]
    public int MotFrame { get; set; }

    [JsonPropertyName("lightShotParamType_")]
    public int LightShotParamType { get; set; }

    [JsonPropertyName("startMoveSpeed_")]
    public float StartMoveSpeed { get; set; }

    [JsonPropertyName("isInterNextMovePass_")]
    public bool IsInterNextMovePass { get; set; }

    [JsonPropertyName("isStartCurrentPos_")]
    public bool IsStartCurrentPos { get; set; }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001MoveToAction);

    [JsonPropertyName("movePassIndex_")]
    public int MovePassIndex { get; set; } = 0;

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = string.Empty;

    [JsonPropertyName("motFrame_")]
    public int MotFrame { get; set; } = 0;

    [JsonPropertyName("lightShotParamType_")]
    public int LightShotParamType { get; set; } = 0;

    [JsonPropertyName("startMoveSpeed_")]
    public float StartMoveSpeed { get; set; } = 30.0f;

    [JsonPropertyName("isInterNextMovePass_")]
    public bool IsInterNextMovePass { get; set; } = false;

    [JsonPropertyName("isStartCurrentPos_")]
    public bool IsStartCurrentPos { get; set; } = false;
}

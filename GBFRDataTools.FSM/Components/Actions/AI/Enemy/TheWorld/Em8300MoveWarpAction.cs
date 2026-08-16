using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300MoveWarpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300MoveWarpAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.4f;

    [JsonPropertyName("moveTargetType_")]
    public int MoveTargetType { get; set; } = 0;

    [JsonPropertyName("targetPos_")]
    public Vector4 TargetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("offsetDist_")]
    public float OffsetDist { get; set; } = 3f;

    [JsonPropertyName("outerMargin_")]
    public float OuterMargin { get; set; } = -1f;

    [JsonPropertyName("isPlayStartMotion_")]
    public bool IsPlayStartMotion { get; set; } = true;

    [JsonPropertyName("isSetRot_")]
    public bool IsSetRot { get; set; } = false;

    [JsonPropertyName("targetRotY_")]
    public float TargetRotY { get; set; } = 0f;

    [JsonPropertyName("isSetInhaleShot_")]
    public bool IsSetInhaleShot { get; set; } = true;
}


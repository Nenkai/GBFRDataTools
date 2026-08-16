using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.AncientDragon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So3900FireBallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So3900FireBallAction);

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1f;

    [JsonPropertyName("blendMotionAddRate_")]
    public float BlendMotionAddRate { get; set; } = 0.02f;

    [JsonPropertyName("degreeMax_")]
    public float DegreeMax { get; set; } = 45f;

    [JsonPropertyName("signSize_")]
    public Vector4 SignSize { get; set; } = Vector4.UnitW;

    [JsonPropertyName("posOffset_")]
    public Vector4 PosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUpdateAttach_")]
    public bool IsUpdateAttach { get; set; } = true;

    [JsonPropertyName("waitMotionInterTime_")]
    public float WaitMotionInterTime { get; set; } = -1f;

    [JsonPropertyName("turnMotionInterTime_")]
    public float TurnMotionInterTime { get; set; } = -1f;

    [JsonPropertyName("shotStartMotionInterTime_")]
    public float ShotStartMotionInterTime { get; set; } = -1f;

    [JsonPropertyName("shotEndMotionInterTime_")]
    public float ShotEndMotionInterTime { get; set; } = -1f;

    [JsonPropertyName("loopInputNum_")]
    public int LoopInputNum { get; set; } = 0;

    [JsonPropertyName("autoTurnTime_")]
    public float AutoTurnTime { get; set; } = 0.5f;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = -1;

    [JsonPropertyName("interCompleteSec_")]
    public float InterCompleteSec { get; set; } = 0.05f;
}

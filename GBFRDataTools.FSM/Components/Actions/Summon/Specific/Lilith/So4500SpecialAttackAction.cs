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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Lilith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4500SpecialAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4500SpecialAttackAction);

    [JsonPropertyName("shotPosOffset_")]
    public Vector4 ShotPosOffset { get; set; } = Vector4.Zero;

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 2f;

    [JsonPropertyName("waitLookTime_")]
    public float WaitLookTime { get; set; } = 0.3f;

    [JsonPropertyName("finishCameraOffset_")]
    public Vector4 FinishCameraOffset { get; set; } = new Vector4(0f, 1.8f, 0f, 1f);

    [JsonPropertyName("finishCameraLength_")]
    public float FinishCameraLength { get; set; } = 4.8f;

    [JsonPropertyName("finishCameraMoveRate_")]
    public float FinishCameraMoveRate { get; set; } = 0.1f;
}

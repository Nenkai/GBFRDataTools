using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkSpecialArtsSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkSpecialArtsSignAction);

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "7000";

    [JsonPropertyName("isUseDarkVFX_")]
    public bool IsUseDarkVFX { get; set; } = true;

    [JsonPropertyName("isEvent_")]
    public bool IsEvent { get; set; } = false;

    [JsonPropertyName("cameraMoveRate_")]
    public float CameraMoveRate { get; set; } = 0.05f;

    [JsonPropertyName("cameraForcusTimeSec_")]
    public float CameraForcusTimeSec { get; set; } = 1f;
}

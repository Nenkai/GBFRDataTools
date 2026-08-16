using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Camera;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CameraRotSetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CameraRotSetAction);

    [JsonPropertyName("rotType_")]
    public int RotType { get; set; } = 0;

    [JsonPropertyName("rotX_")]
    public float RotX { get; set; } = 0f;

    [JsonPropertyName("rotY_")]
    public float RotY { get; set; } = 0f;

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 0f;
}

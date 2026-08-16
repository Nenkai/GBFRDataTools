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
public class CameraStopShakeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CameraStopShakeAction);

    [JsonPropertyName("immediateEnd_")]
    public bool ImmediateEnd { get; set; } = false;
}

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
public class SetCameraOwnerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetCameraOwnerAction);

    [JsonPropertyName("isSet_")]
    public bool IsSet { get; set; } = true;

    [JsonPropertyName("isNoInterp_")]
    public bool IsNoInterp { get; set; } = false;

    [JsonPropertyName("returnGameCameraInterTime_")]
    public float ReturnGameCameraInterTime { get; set; } = 0f;

    [JsonPropertyName("isUpdatePhotoTarget_")]
    public bool IsUpdatePhotoTarget { get; set; } = true;
}

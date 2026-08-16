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

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonCameraRecoilAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCameraRecoilAction);

    [JsonPropertyName("recoilType_")]
    public int RecoilType { get; set; } = 0;

    [JsonPropertyName("recoilFrame_")]
    public int RecoilFrame { get; set; } = 1;

    [JsonPropertyName("recoilRate_")]
    public float RecoilRate { get; set; } = 0f;

    [JsonPropertyName("addCameraRotX_")]
    public float AddCameraRotX { get; set; } = 0f;

    [JsonPropertyName("addCameraRotY_")]
    public float AddCameraRotY { get; set; } = 0f;

    [JsonPropertyName("isOnce_")]
    public bool IsOnce { get; set; } = false;
}

using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7600RampageAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600RampageAction);

    [JsonPropertyName("offset1st_")]
    public Vector4 Offset1st { get; set; } = Vector4.UnitW;

    [JsonPropertyName("offset2nd_")]
    public Vector4 Offset2nd { get; set; } = Vector4.UnitW;

    [JsonPropertyName("angle1st_")]
    public float Angle1st { get; set; } = 0f;

    [JsonPropertyName("angle2nd_")]
    public float Angle2nd { get; set; } = 0f;

    [JsonPropertyName("angleSpread_")]
    public float AngleSpread { get; set; } = 0f;

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.005f;
}
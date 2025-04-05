using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

public class Em0501IceWaveEffectAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0501IceWaveEffectAction);

    [JsonPropertyName("scaleTime_")]
    public float ScaleTime { get; set; } = 1.0f;

    [JsonPropertyName("scaleBegin_")]
    public /* cVec4 */ Vector4 ScaleBegin { get; set; } = Vector4.UnitW;

    [JsonPropertyName("scaleEnd_")]
    public /* cVec4 */ Vector4 ScaleEnd { get; set; } = new Vector4(2.0f, 2.0f, 2.0f, 1.0f);

    [JsonPropertyName("vanish_")]
    public bool Vanish { get; set; } = false;
}

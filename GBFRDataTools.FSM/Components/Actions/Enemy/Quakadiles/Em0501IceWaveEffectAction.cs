using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

public class Em0501IceWaveEffectAction : Em0500SplineAction
{
    [JsonPropertyName("scaleTime_")]
    public float ScaleTime { get; set; }

    [JsonPropertyName("scaleBegin_")]
    public cVec4 ScaleBegin { get; set; }

    [JsonPropertyName("scaleEnd_")]
    public cVec4 ScaleEnd { get; set; }

    [JsonPropertyName("vanish_")]
    public bool Vanish { get; set; }
}

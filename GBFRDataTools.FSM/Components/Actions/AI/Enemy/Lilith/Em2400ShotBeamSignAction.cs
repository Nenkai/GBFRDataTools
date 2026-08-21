using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lilith;

public class Em2400ShotBeamSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400ShotBeamSignAction);

    [JsonPropertyName("size_")]
    public Vector4 Size { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("dispSec_")]
    public float DispSec { get; set; } = 1f; 

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW; 
}

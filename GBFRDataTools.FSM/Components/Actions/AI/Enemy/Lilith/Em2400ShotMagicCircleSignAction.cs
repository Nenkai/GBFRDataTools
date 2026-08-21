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

public class Em2400ShotMagicCircleSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400ShotMagicCircleSignAction);

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1f; 

    [JsonPropertyName("dispSec_")]
    public float DispSec { get; set; } = 1f; 
}

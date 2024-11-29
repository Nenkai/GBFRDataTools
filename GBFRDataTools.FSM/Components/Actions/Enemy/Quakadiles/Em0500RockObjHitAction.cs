using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

public class Em0500RockObjHitAction : ActionComponent
{
    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 10.0f;

    [JsonPropertyName("height_")]
    public float Height { get; set; } = 2.0f;

    [JsonPropertyName("massScale_")]
    public float MassScale { get; set; } = 5000.0f;
}

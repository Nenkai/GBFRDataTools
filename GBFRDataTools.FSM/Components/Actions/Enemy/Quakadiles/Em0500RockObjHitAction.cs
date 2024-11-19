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
    public float Radius { get; set; }

    [JsonPropertyName("height_")]
    public float Height { get; set; }

    [JsonPropertyName("massScale_")]
    public float MassScale { get; set; }
}

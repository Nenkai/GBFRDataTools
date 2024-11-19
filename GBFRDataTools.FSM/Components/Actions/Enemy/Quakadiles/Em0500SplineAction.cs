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

public class Em0500SplineAction : ActionComponent
{
    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("height_")]
    public float Height { get; set; }

    [JsonPropertyName("rotateDirection_")]
    public bool RotateDirection { get; set; }

    [JsonPropertyName("endTimer_")]
    public bool EndTimer { get; set; }

}
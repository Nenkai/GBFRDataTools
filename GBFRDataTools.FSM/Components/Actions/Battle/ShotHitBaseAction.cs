
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

public class ShotHitBaseAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public cVec4 Offset { get; set; }

    [JsonPropertyName("size_")]
    public cVec4 Size { get; set; }

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; }

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; }

    [JsonPropertyName("degreeZ_")]
    public float DegreeZ { get; set; }

    [JsonPropertyName("shape_")]
    public int Shape { get; set; }
}
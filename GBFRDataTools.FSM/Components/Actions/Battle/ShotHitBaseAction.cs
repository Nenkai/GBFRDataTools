using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotHitBaseAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public /* cVec4 */ Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("size_")]
    public /* cVec4 */ Vector4 Size { get; set; } = Vector4.One;

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; }

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; }

    [JsonPropertyName("degreeZ_")]
    public float DegreeZ { get; set; }

    [JsonPropertyName("shape_")]
    public ShapeType Shape { get; set; }
}
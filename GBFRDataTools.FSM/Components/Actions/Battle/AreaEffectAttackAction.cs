using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;
using System.ComponentModel;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectAttackAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public cVec4 Offset { get; set; }

    [JsonPropertyName("size_")]
    public cVec4 Size { get; set; }

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; }

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; }

    [JsonPropertyName("shape_")]
    public ShapeType Shape { get; set; }

    [JsonPropertyName("direction_")]
    public int Direction { get; set; }

    [JsonPropertyName("target_")]
    public int Target { get; set; }

    [JsonPropertyName("globalType_")]
    public int GlobalType { get; set; }

    [JsonPropertyName("type_")]
    public int Type { get; set; }

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; }

    [JsonPropertyName("hitFlag_")]
    public ulong HitFlag { get; set; }

    [JsonPropertyName("categoryFlag_")]
    public int CategoryFlag { get; set; }

    [JsonPropertyName("element_")]
    public int Element { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("badStatus_")]
    public int BadStatus { get; set; }

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; }

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; }

    [JsonPropertyName("spArtsRate_")]
    public float SpArtsRate { get; set; }

    [JsonPropertyName("hitStopSecond_")]
    public float HitStopSecond { get; set; }

    [JsonPropertyName("hitVibrationType_")]
    public int HitVibrationType { get; set; }

    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; }

    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; }

    [JsonPropertyName("deleySecond_")]
    public float DeleySecond { get; set; }

    [JsonPropertyName("isMultiHit_")]
    public bool IsMultiHit { get; set; }

    [JsonPropertyName("debuffList_")]
    public BindingList<DebuffData> DebuffList { get; set; }

    [JsonPropertyName("isSwept_")]
    public bool IsSwept { get; set; }
}

public class DebuffData
{
    [JsonPropertyName("category")]
    public int Category { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("sec")]
    public float Sec { get; set; }

    [JsonPropertyName("rate")]
    public float Rate { get; set; }
}

public enum ShapeType
{
    Shape0 = 0,
    Shape1 = 1,
    Shape2 = 2,
    Shape3 = 3,
    Shape4 = 4,
    Shape5 = 5,
    Shape6 = 6,
    Shape7 = 7,

}
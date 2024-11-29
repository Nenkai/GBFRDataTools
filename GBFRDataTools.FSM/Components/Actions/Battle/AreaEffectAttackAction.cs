﻿using System;
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

public class AreaEffectAttackAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public /* cVec4 */ Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("size_")]
    public /* cVec4 */ Vector4 Size { get; set; } = Vector4.One;

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; } = 0.0f;

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; } = 0.0f;

    [JsonPropertyName("shape_")]
    public ShapeType Shape { get; set; } = ShapeType.Shape0;

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0;

    [JsonPropertyName("target_")]
    public int Target { get; set; } = 0;

    [JsonPropertyName("globalType_")]
    public int GlobalType { get; set; } = 0;

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; } = 0;

    [JsonPropertyName("hitFlag_")]
    public ulong HitFlag { get; set; } = 0;

    [JsonPropertyName("categoryFlag_")]
    public int CategoryFlag { get; set; } = 0;

    [JsonPropertyName("element_")]
    public int Element { get; set; } = 0;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("badStatus_")]
    public int BadStatus { get; set; }

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } = 1.0f;

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } = 1.0f;

    [JsonPropertyName("spArtsRate_")]
    public float SpArtsRate { get; set; } = 0.0f;

    [JsonPropertyName("hitStopSecond_")]
    public float HitStopSecond { get; set; } = 1.0f;

    [JsonPropertyName("hitVibrationType_")]
    public int HitVibrationType { get; set; } = 0;

    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; } = 0.0f;

    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; } = 0.0f;

    [JsonPropertyName("deleySecond_")]
    public float DeleySecond { get; set; } = 0.0f;

    [JsonPropertyName("isMultiHit_")]
    public bool IsMultiHit { get; set; } = false;

    [JsonPropertyName("debuffList_")]
    public BindingList<DebuffData> DebuffList { get; set; } = [];

    [JsonPropertyName("isSwept_")]
    public bool IsSwept { get; set; } = false;
}

public class DebuffData
{
    [JsonPropertyName("category")]
    public int Category { get; set; } = 0;

    [JsonPropertyName("type")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("sec")]
    public float Sec { get; set; } = 0.0f;

    [JsonPropertyName("rate")]
    public float Rate { get; set; } = 0.0f;
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
using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreAtkTackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreAtkTackleAction);

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 1.5f;

    [JsonPropertyName("startMotionIdName_")]
    public string StartMotionIdName { get; set; }

    [JsonPropertyName("moveMotionIdName_")]
    public string MoveMotionIdName { get; set; }

    [JsonPropertyName("attackMotionIdName_")]
    public string AttackMotionIdName { get; set; }

    [JsonPropertyName("penetrationDistance_")]
    public float PenetrationDistance { get; set; } = 3f;

    [JsonPropertyName("moveMaxTime_")]
    public float MoveMaxTime { get; set; } = 1.5f;

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0;

    [JsonPropertyName("isCancelMotion_")]
    public bool IsCancelMotion { get; set; } = false;
}

using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkGeneralAction : Em8300AtkDimensionBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkGeneralAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; }

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = -1f;

    [JsonPropertyName("moveDist1_")]
    public float MoveDist1 { get; set; } = 10f;

    [JsonPropertyName("moveRateMax1_")]
    public float MoveRateMax1 { get; set; } = 1f;

    [JsonPropertyName("moveDist2_")]
    public float MoveDist2 { get; set; } = 10f;

    [JsonPropertyName("moveRateMax2_")]
    public float MoveRateMax2 { get; set; } = 1f;

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1f;
}
using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300ShotMoveOrbitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300ShotMoveOrbitAction);

    [JsonPropertyName("isAngularVelocity_")]
    public bool IsAngularVelocity { get; set; } = false;

    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; } = 5f;

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 5f;

    [JsonPropertyName("isCorrectSpeed_")]
    public bool IsCorrectSpeed { get; set; } = false;

    [JsonPropertyName("radiusVelocity_")]
    public float RadiusVelocity { get; set; } = 2f;

    [JsonPropertyName("downSpeed_")]
    public float DownSpeed { get; set; } = 1f;

    [JsonPropertyName("centerPosOffset_")]
    public Vector4 CenterPosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUpdateRot_")]
    public bool IsUpdateRot { get; set; } = false;

    [JsonPropertyName("lifeTime_")]
    public float LifeTime { get; set; } = -1f;
}
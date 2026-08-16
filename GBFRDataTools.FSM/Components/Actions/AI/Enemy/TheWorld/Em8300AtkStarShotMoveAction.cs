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
public class Em8300AtkStarShotMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkStarShotMoveAction);

    [JsonPropertyName("centerPos_")]
    public Vector4 CenterPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 0f;

    [JsonPropertyName("randomHeight")]
    public float RandomHeight { get; set; } = 0f;

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 2f;

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 8f;
}
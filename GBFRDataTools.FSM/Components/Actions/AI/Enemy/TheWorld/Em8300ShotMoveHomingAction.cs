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
public class Em8300ShotMoveHomingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300ShotMoveHomingAction);

    [JsonPropertyName("homingTime_")]
    public float HomingTime { get; set; } = 1f;

    [JsonPropertyName("homingSpeedInit_")]
    public float HomingSpeedInit { get; set; } = 3f;

    [JsonPropertyName("homingSpeedFinish_")]
    public float HomingSpeedFinish { get; set; } = 4f;

    [JsonPropertyName("isRotTarget_")]
    public bool IsRotTarget { get; set; } = false;
}
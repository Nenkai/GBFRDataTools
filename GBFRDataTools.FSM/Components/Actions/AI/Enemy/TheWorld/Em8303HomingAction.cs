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
public class Em8303HomingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8303HomingAction);

    [JsonPropertyName("actionWaitTime_")]
    public float ActionWaitTime { get; set; } = 7f;

    [JsonPropertyName("traceAttackWaitTime_")]
    public float TraceAttackWaitTime { get; set; } = 3f;

    [JsonPropertyName("traceAttackTime_")]
    public float TraceAttackTime { get; set; } = 0.3f;

    [JsonPropertyName("traceAttackEndTime_")]
    public float TraceAttackEndTime { get; set; } = 2f;

    [JsonPropertyName("laserFirstPosRadius_")]
    public float LaserFirstPosRadius { get; set; } = 10f;
}

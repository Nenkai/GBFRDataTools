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
public class Em8300WaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300WaitAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 1f;

    [JsonPropertyName("isHoming_")]
    public bool IsHoming { get; set; } = false;
}
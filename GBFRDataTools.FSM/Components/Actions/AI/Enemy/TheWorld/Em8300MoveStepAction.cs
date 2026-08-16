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
public class Em8300MoveStepAction : Em8300AtkShotAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300MoveStepAction);

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0;

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 1f;
}


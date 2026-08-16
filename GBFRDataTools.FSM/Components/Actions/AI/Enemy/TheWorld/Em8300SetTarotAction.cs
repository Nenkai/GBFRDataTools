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
public class Em8300SetTarotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300SetTarotAction);

    [JsonPropertyName("isFirstDeal_")]
    public bool IsFirstDeal { get; set; } = false;

    [JsonPropertyName("isSpartsDeal_")]
    public bool IsSpartsDeal { get; set; } = false;

    [JsonPropertyName("isTarotAccel_")]
    public bool IsTarotAccel { get; set; } = false;

    [JsonPropertyName("accelTime_")]
    public float AccelTime { get; set; } = 30f;
}


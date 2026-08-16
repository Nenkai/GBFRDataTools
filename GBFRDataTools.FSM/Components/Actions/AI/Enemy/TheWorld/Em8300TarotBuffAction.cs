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
public class Em8300TarotBuffAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300TarotBuffAction);

    [JsonPropertyName("camTargetSec_")]
    public float CamTargetSec { get; set; } = 3f;

    [JsonPropertyName("camTargetRate_")]
    public float CamTargetRate { get; set; } = 0.1f;

    [JsonPropertyName("rotMax_")]
    public float RotMax { get; set; } = 6.2831855f;

    [JsonPropertyName("moveRotMax_")]
    public float MoveRotMax { get; set; } = 3.1415927f;

    [JsonPropertyName("isWeak_")]
    public bool IsWeak { get; set; } = false;

    [JsonPropertyName("weakTime_")]
    public float WeakTime { get; set; } = 0.3f;
}
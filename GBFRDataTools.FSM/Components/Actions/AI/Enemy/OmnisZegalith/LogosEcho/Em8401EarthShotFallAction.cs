using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401EarthShotFallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401EarthShotFallAction);

    [JsonPropertyName("moveYSpeed_")]
    public float MoveYSpeed { get; set; } = 1f;

    [JsonPropertyName("adjustPosY_")]
    public float AdjustPosY { get; set; } = 2f;
}

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
public class Em8401WaterShotLineSeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401WaterShotLineSeAction);

    [JsonPropertyName("seName_")]
    public string SeName { get; set; }

    [JsonPropertyName("lineLength_")]
    public float LineLength { get; set; } = 52f;

    [JsonPropertyName("isStopSe_")]
    public bool IsStopSe { get; set; } = false;
}

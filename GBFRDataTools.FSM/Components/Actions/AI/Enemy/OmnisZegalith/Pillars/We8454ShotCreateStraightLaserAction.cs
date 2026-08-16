using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.Pillars;

[GameSupport(GameVersion.EndlessRagnarok)]
public class We8454ShotCreateStraightLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We8454ShotCreateStraightLaserAction);

    [JsonPropertyName("useCustomLifeTime_")]
    public bool UseCustomLifeTime { get; set; } = false;

    [JsonPropertyName("customLifeTime_")]
    public float CustomLifeTime { get; set; } = 1f;
}

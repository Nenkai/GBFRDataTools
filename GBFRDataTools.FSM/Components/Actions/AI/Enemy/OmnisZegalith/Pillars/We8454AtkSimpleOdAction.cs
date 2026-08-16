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
public class We8454AtkSimpleOdAction : Em8400ElementCoreAtkSimpleOdBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(We8454AtkSimpleOdAction);

    [JsonPropertyName("isStageOffset_")]
    public bool IsStageOffset { get; set; } = false;

    [JsonPropertyName("rotateLaserOffset_")]
    public Vector4 RotateLaserOffset { get; set; } = Vector4.UnitW;
}

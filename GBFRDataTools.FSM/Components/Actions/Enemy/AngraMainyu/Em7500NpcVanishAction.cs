using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.AngraMainyu;

public class Em7500NpcVanishAction : ActionComponent
{
    [JsonPropertyName("moveY_")]
    public float MoveY { get; set; } = 4.0f;

    [JsonPropertyName("targetMoveTime_")]
    public float TargetMoveTime { get; set; } = 3.0f;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("vanishWaitTime_")]
    public float VanishWaitTime { get; set; }
}

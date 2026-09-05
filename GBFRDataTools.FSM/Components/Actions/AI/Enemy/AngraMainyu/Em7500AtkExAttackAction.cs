using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7500AtkExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AtkExAttackAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 10f;

    [JsonPropertyName("isDownCamera_")]
    public bool IsDownCamera { get; set; } = false;

    [JsonPropertyName("isLightPillerStun_")]
    public bool IsLightPillerStun { get; set; } = false;
}


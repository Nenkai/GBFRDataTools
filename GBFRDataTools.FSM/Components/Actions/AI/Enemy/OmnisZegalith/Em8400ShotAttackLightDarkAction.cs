using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotAttackLightDarkAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotAttackLightDarkAction);

    [JsonPropertyName("lightDarkStatus_")]
    [Obsolete("Not used by executable")]
    public int LightDarkStatus { get; set; } = 0;
}

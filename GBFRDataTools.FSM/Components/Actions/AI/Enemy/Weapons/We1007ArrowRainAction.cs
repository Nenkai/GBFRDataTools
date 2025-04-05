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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Weapons;

public class We1007ArrowRainAction : ShotAttackSignAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(We1007ArrowRainAction);

    [JsonPropertyName("signWaitTime_")]
    public float SignWaitTime { get; set; } = 0.3f;
}

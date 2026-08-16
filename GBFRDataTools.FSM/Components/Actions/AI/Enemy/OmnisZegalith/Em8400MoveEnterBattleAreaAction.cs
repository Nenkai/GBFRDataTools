using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400MoveEnterBattleAreaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400MoveEnterBattleAreaAction);

    [JsonPropertyName("distanceByAreaCenterPos_")]
    public float DistanceByAreaCenterPos { get; set; } = 50f;

    [JsonPropertyName("actionEndDelayTimeSec_")]
    public float ActionEndDelayTimeSec { get; set; } = 1.5f;
}

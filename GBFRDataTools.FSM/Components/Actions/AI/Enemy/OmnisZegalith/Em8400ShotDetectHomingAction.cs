using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

using static GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen.Em8100ChooseNextAction;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable")]
public class Em8400ShotDetectHomingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotDetectHomingAction);

    [JsonPropertyName("minDitectDist_")]
    public float MinDitectDist { get; set; }

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; }

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; }

    [JsonPropertyName("frontDegree_")]
    public float FrontDegree { get; set; }
}
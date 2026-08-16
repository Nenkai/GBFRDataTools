using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Behemoth;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So3700SetBlackBoardBlendRateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So3700SetBlackBoardBlendRateAction);

    [JsonPropertyName("blendRateVectorName_")]
    public string BlendRateVectorName { get; set; }

    [JsonPropertyName("minDistanceThreshold_")]
    public float MinDistanceThreshold { get; set; } = 0f;
}

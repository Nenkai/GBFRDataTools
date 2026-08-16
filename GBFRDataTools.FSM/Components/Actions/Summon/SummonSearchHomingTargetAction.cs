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

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonSearchHomingTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSearchHomingTargetAction);

    [JsonPropertyName("searchCenterPos_")]
    public Vector4 SearchCenterPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUseBlackBoardPos_")]
    public bool IsUseBlackBoardPos { get; set; } = false;

    [JsonPropertyName("blackBoardPosKey_")]
    public string BlackBoardPosKey { get; set; }

    [JsonPropertyName("searchRadius_")]
    public float SearchRadius { get; set; } = 0f;
}
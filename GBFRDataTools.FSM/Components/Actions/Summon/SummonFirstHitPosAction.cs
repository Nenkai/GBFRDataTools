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
public class SummonFirstHitPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonFirstHitPosAction);

    [JsonPropertyName("posBlackBoardValueName_")]
    public string PosBlackBoardValueName { get; set; }

    [JsonPropertyName("hitBlackBoardValueName_")]
    public string HitBlackBoardValueName { get; set; }

    [JsonPropertyName("isUsePos_")]
    public bool IsUsePos { get; set; } = true;

    [JsonPropertyName("isUseHit_")]
    public bool IsUseHit { get; set; } = true;
}

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
public class SummonCheckWallRotateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCheckWallRotateAction);

    [JsonPropertyName("checkWallLength_")]
    public float CheckWallLength { get; set; } = 0f;

    [JsonPropertyName("checkGroundLength_")]
    public float CheckGroundLength { get; set; } = 0f;

    [JsonPropertyName("rotOutputBlackBoardValueName_")]
    public string RotOutputBlackBoardValueName { get; set; }

    [JsonPropertyName("isNoValidDirectionValueName_")]
    public string IsNoValidDirectionValueName { get; set; }
}

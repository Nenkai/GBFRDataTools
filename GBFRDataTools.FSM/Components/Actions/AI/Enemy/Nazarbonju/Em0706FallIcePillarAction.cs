using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706FallIcePillarAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706FallIcePillarAction);

    [JsonPropertyName("isOdAbilityBefore_")]
    public bool IsOdAbilityBefore { get; set; } = false;

    [JsonPropertyName("isExStart_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsExStart { get; set; } = false;

    [JsonPropertyName("chaosCenterPos_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public Vector4 ChaosCenterPos { get; set; } = new Vector4(-270f, 88.4f, -52f, 1f);

    [JsonPropertyName("chaosStageRadius_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float ChaosStageRadius { get; set; } = 25f;
}
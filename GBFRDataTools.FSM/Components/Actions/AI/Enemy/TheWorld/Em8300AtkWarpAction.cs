using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkWarpAction : Em8300AtkDimensionBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkWarpAction);

    [JsonPropertyName("isSummerSalt_")]
    public bool IsSummerSalt { get; set; } = false;

    [JsonPropertyName("isVerticalDoubleChop_")]
    public bool IsVerticalDoubleChop { get; set; } = false;

    [JsonPropertyName("isHorizontalDoubleChop_")]
    public bool IsHorizontalDoubleChop { get; set; } = false;

    [JsonPropertyName("isSkipPreAction_")]
    public bool IsSkipPreAction { get; set; } = false;

    [JsonPropertyName("isInvincibleWarp_")]
    public bool IsInvincibleWarp { get; set; } = false;

    [JsonPropertyName("warpOffsetDist_")]
    public float WarpOffsetDist { get; set; } = 7.7f;

    [JsonPropertyName("warpWaitTime_")]
    public float WarpWaitTime { get; set; } = 1f;

    [JsonPropertyName("isCreateInhaleShot_")]
    public bool IsCreateInhaleShot { get; set; } = true;

    public Em8300AtkWarpAction()
    {
        DimensionType = 0;
    }
}
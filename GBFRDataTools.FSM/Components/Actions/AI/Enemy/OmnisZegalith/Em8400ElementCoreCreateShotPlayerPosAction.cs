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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreCreateShotPlayerPosAction : Em8400ElementCoreCreateShotBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreCreateShotPlayerPosAction);

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("offsetRotY_")]
    public float OffsetRotY { get; set; } = 0f;

    [JsonPropertyName("shotSlot_")]
    public int ShotSlot { get; set; } = 0;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0f;

    [JsonPropertyName("userCustomType_")]
    public int UserCustomType { get; set; } = 0;

    [JsonPropertyName("isTargetPlayer_")]
    public bool IsTargetPlayer { get; set; } = false;
}

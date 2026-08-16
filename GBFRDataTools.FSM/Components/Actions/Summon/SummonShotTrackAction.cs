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
public class SummonShotTrackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonShotTrackAction);

    [JsonPropertyName("useShotId_")]
    public int UseShotId { get; set; } = 0;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = -1;

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shotOffsetDeg_")]
    public Vector4 ShotOffsetDeg { get; set; } = Vector4.UnitW;
}

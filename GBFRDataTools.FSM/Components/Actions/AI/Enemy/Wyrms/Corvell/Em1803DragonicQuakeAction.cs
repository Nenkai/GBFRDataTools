using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Corvell;

public class Em1803DragonicQuakeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1803DragonicQuakeAction);

    [JsonPropertyName("sandWallOffsetPosZ_")]
    public float SandWallOffsetPosZ { get; set; } = 6.5f; // Offset 0x1B8

    [JsonPropertyName("tackleStartRange_")]
    public float TackleStartRange { get; set; } = 10f; // Offset 0x1BC

    [JsonPropertyName("diveEndLoopTimeSec_")]
    public float DiveEndLoopTimeSec { get; set; } = 1f; // Offset 0x1C0

    [JsonPropertyName("beamBeforeDiveEndLoopTimeSec_")]
    public float BeamBeforeDiveEndLoopTimeSec { get; set; } = 1f; // Offset 0x1C4

    [JsonPropertyName("diveMoveLength_")]
    public float DiveMoveLength { get; set; } = 1f; // Offset 0x1C8

    [JsonPropertyName("rockOverlapLength_")]
    public float RockOverlapLength { get; set; } = 1f; // Offset 0x1CC

    [JsonPropertyName("rockFallTimeAdjust_")]
    public Vector2 RockFallTimeAdjust { get; set; } = new Vector2(1f, 3f); // Offset 0x1D0

    [JsonPropertyName("createWallLength_")]
    public float CreateWallLength { get; set; } = 5f; // Offset 0x1D8

    [JsonPropertyName("homingLimitAngle_")]
    public float HomingLimitAngle { get; set; } = 5f; // Offset 0x1DC

    [JsonPropertyName("flyLimitHeight_")]
    public float FlyLimitHeight { get; set; } = 10f; // Offset 0x1E0

    [JsonPropertyName("diveSignAddHeight_")]
    public float DiveSignAddHeight { get; set; } = 1f; // Offset 0x1E4

    [JsonPropertyName("diveSignLimitHeight_")]
    public float DiveSignLimitHeight { get; set; } = 5f; // Offset 0x1E8

    [JsonPropertyName("diveAngle_")]
    public float DiveAngle { get; set; } = 10f; // Offset 0x1EC

    [JsonPropertyName("signOffsetLength_")]
    public float SignOffsetLength { get; set; } = 17f; // Offset 0x1F0

    [JsonPropertyName("signSec_")]
    public float SignSec { get; set; } = 2f; // Offset 0x1F4

    [JsonPropertyName("signEndEffectSec_")]
    public float SignEndEffectSec { get; set; } = 0.2f; // Offset 0x1F8

    [JsonPropertyName("signRectSize_")]
    public Vector4 SignRectSize { get; set; } = new Vector4(13f, 1f, 30f, 1f); // Offset 0x200

    public Em1803DragonicQuakeAction()
    {
    }
}

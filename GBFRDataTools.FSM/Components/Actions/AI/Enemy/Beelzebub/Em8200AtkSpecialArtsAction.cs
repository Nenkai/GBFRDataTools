using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200AtkSpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkSpecialArtsAction);

    [JsonPropertyName("inhaleSpeed_")]
    public float InhaleSpeed { get; set; } = 3f;

    [JsonPropertyName("inhaleStartSec_")]
    public float InhaleStartSec { get; set; } = 0.1f;

    [JsonPropertyName("firstShotWaitSec_")]
    public float FirstShotWaitSec { get; set; } = 2f;

    [JsonPropertyName("shotIntervalSec_")]
    public float ShotIntervalSec { get; set; } = 0.5f;

    [JsonPropertyName("shotSignSecEndless_")]
    public BindingList<float> ShotSignSecEndless { get; set; } = [.. Enumerable.Repeat(0.0f, 2)]; // std::array<float,2>

    [JsonPropertyName("shotSignSecMulti_")]
    public BindingList<float> ShotSignSecMulti { get; set; } = [.. Enumerable.Repeat(0.0f, 2)]; // std::array<float,2>

    [JsonPropertyName("spShotSignSec_")]
    public float SpShotSignSec { get; set; } = 1f;

    [JsonPropertyName("shotSignWidth_")]
    public float ShotSignWidth { get; set; } = 4f;

    [JsonPropertyName("shotSpaceWidth_")]
    public float ShotSpaceWidth { get; set; } = 6f;

    [JsonPropertyName("shotDistance_")]
    public float ShotDistance { get; set; } = 15f;

    [JsonPropertyName("lastAttackCameraWaitSec_")]
    public float LastAttackCameraWaitSec { get; set; } = 1f;

    [JsonPropertyName("inhaleVfxWaitSec_")]
    public float InhaleVfxWaitSec { get; set; } = 1.5f;

    [JsonPropertyName("inhaleOffsetLength_")]
    public float InhaleOffsetLength { get; set; } = 10f;

    [JsonPropertyName("cameraLookAtSec_")]
    public float CameraLookAtSec { get; set; } = 1f;

    [JsonPropertyName("cameraLookAtMoveRate_")]
    public float CameraLookAtMoveRate { get; set; } = 0.1f;

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 6;

    [JsonPropertyName("mixedShotNum_")]
    public int MixedShotNum { get; set; } = 5;

    [JsonPropertyName("dangerousAreaDegree_")]
    public float DangerousAreaDegree { get; set; } = 300f;

    [JsonPropertyName("lastAttackCameraLookAtSec_")]
    public float LastAttackCameraLookAtSec { get; set; } = 0.5f;

    [JsonPropertyName("lastAttackCameraLookAtMoveRate_")]
    public float LastAttackCameraLookAtMoveRate { get; set; } = 0.5f;

    [JsonPropertyName("lastAttackCameraLookAtMoveRotMax_")]
    public float LastAttackCameraLookAtMoveRotMax { get; set; } = 3.1415927f;

    [JsonPropertyName("lastAttackLoopSec_")]
    public float LastAttackLoopSec { get; set; } = 3f;

    [JsonPropertyName("lastAttackSignWaitSec_")]
    public float LastAttackSignWaitSec { get; set; } = 3f;

    [JsonPropertyName("lastAttackEndSec_")]
    public float LastAttackEndSec { get; set; } = 0.8f;

    [JsonPropertyName("nextLastAttackWaitSec_")]
    public float NextLastAttackWaitSec { get; set; } = 0.1f;

    [JsonPropertyName("moveIntervalSec_")]
    public float MoveIntervalSec { get; set; } = 0.1f;

    [JsonPropertyName("blackSpearStartSec_")]
    public float BlackSpearStartSec { get; set; } = 2f;

    [JsonPropertyName("lastAttackRotY_")]
    public float LastAttackRotY { get; set; } = -65f;

    [JsonPropertyName("lastAttackOffsetX_")]
    public float LastAttackOffsetX { get; set; } = 10f;

    [JsonPropertyName("lastAttackOffsetZ_")]
    public float LastAttackOffsetZ { get; set; } = -10f;

    [JsonPropertyName("gridRotY_")]
    public float GridRotY { get; set; } = 45f;

    [JsonPropertyName("warpVfxFrame_")]
    public int WarpVfxFrame { get; set; } = 40;

    [JsonPropertyName("ownerSitPos_")]
    public Vector4 OwnerSitPos { get; set; } = new Vector4(0f, 12.79f, -51.27f, 1f);

    [JsonPropertyName("createVineSec_")]
    public BindingList<float> CreateVineSec { get; set; } = [.. Enumerable.Repeat(0.0f, 2)]; // std::array<float,2>

    [JsonPropertyName("isForceSecondSpArts_")]
    public bool IsForceSecondSpArts { get; set; } = false;
}
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

[Obsolete("Not in the executable")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotCreateShotCircleAction : Em8400ElementCoreCreateShotBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotCreateShotCircleAction);

    [JsonPropertyName("shotType_")]
    public int ShotType { get; set; } = 0;

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("shotCount_")]
    public int ShotCount { get; set; } = 1;

    [JsonPropertyName("createInterval_")]
    public float CreateInterval { get; set; } = 0f;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 10f;

    [JsonPropertyName("addRadius_")]
    public float AddRadius { get; set; } = 0f;

    [JsonPropertyName("offsetRotY_")]
    public float OffsetRotY { get; set; } = 0f;

    [JsonPropertyName("addRotY_")]
    public float AddRotY { get; set; } = 0f;

    [JsonPropertyName("createShotOffsetRotY_")]
    public float CreateShotOffsetRot { get; set; } = 0;

    [JsonPropertyName("createShotOffsetRadiusRandom_")]
    public float CreateShotOffsetRadiusRandom { get; set; } = 0f;

    [JsonPropertyName("userCustomType_")]
    public int UserCustomType { get; set; } = 0;

    [JsonPropertyName("isUseOwnerPos_")]
    public bool IsUseOwnerPos { get; set; } = true;

    [JsonPropertyName("isUseOwnerRotY_")]
    public bool IsUseOwnerRotY { get; set; } = true;

    [JsonPropertyName("isUseOwnerParts_")]
    public bool IsUseOwnerParts { get; set; } = false;

    [JsonPropertyName("ownerPratsNo_")]
    public int OwnerPratsNo { get; set; } = -1;
}

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotCreateLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotCreateLaserAction);

    [JsonPropertyName("lightDarkStatus_")]
    [Obsolete("Not used by executable")]
    public int LightDarkStatus { get; set; } = 0;

    [JsonPropertyName("useShotPartsNo_")]
    public bool UseShotPartsNo { get; set; } = false;

    [JsonPropertyName("useEndShotPartsNo_")]
    public bool UseEndShotPartsNo { get; set; } = false;

    [JsonPropertyName("useRotPartsNo_")]
    public bool UseRotPartsNo { get; set; } = false;

    [JsonPropertyName("useRotOwner_")]
    public bool UseRotOwner { get; set; } = false;

    [JsonPropertyName("shotPratsNo_")]
    public int ShotPratsNo { get; set; } = -1;

    [JsonPropertyName("isSearchTarget_")]
    public bool IsSearchTarget { get; set; } = false;

    [JsonPropertyName("searchRadius_")]
    public float SearchRadius { get; set; } = 60f;

    [JsonPropertyName("searchAngleY_")]
    public float SearchAngleY { get; set; } = 1f;
}

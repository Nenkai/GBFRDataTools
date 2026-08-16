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
public class Em8400CutinLastEventAction : Em8400CutinBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400CutinLastEventAction);

    [JsonPropertyName("playerDistance_")]
    public float PlayerDistance { get; set; } = 0f;

    [JsonPropertyName("endCameraInterSec_")]
    public float EndCameraInterSec { get; set; } = 0.5f;

    [JsonPropertyName("crisisGaugeDispTimeSec_")]
    public float CrisisGaugeDispTimeSec { get; set; } = 2f;

    [JsonPropertyName("playerHpHealFrameDelay_")]
    public int PlayerHpHealFrameDelay { get; set; } = 40;

    public Em8400CutinLastEventAction()
    {
        IsResetCamera = true;
        CanSkipCutin = false;
        UseCutMax = 1;
        IsUseDarkVfx = true;
    }
}

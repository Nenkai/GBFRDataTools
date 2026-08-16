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
public class Em8400CutinSpecialArtsAction : Em8400CutinBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400CutinSpecialArtsAction);

    [JsonPropertyName("isSeamlessCamera_")]
    public bool IsSeamlessCamera { get; set; } = true;

    [JsonPropertyName("motionEndInterFrame_")]
    public int MotionEndInterFrame { get; set; } = 30;

    [JsonPropertyName("motPlaylastPos_")]
    public Vector4 MotPlaylastPos { get; set; } = new Vector4(-40f, 180f, 900f, 1f);

    [JsonPropertyName("playerPos_")]
    public Vector4 PlayerPos { get; set; } = new Vector4(1.694f, 12.109f, -50.415f, 1f);

    [JsonPropertyName("cameraTargetPos_")]
    public Vector4 CameraTargetPos { get; set; } = new Vector4(-40f, 0f, 900f, 1f);

    public Em8400CutinSpecialArtsAction()
    {
        IsResetCamera = true;
        CanSkipCutin = false;
        UseCutMax = 1;
        IsUseDarkVfx = true;
    }
}

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
public class Em8400AtkBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkBeamAction);

    [JsonPropertyName("attackSignSize_")]
    public float AttackSignSize { get; set; } = 6f;

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } = 3f;

    [JsonPropertyName("beamParamList_")]
    public BindingList<BeamParameter> BeamParamList { get; set; } = []; // std::vector<BT::Em8400AtkBeamAction::BeamParameter>

    [JsonPropertyName("beamMoveTimeSec_")]
    public float BeamMoveTimeSec { get; set; } = 1.5f;

    [JsonPropertyName("beamStartRotX_")]
    public float BeamStartRotX { get; set; } = 90f;

    [JsonPropertyName("beamEndRotX_")]
    public float BeamEndRotX { get; set; } = 0f;

    [JsonPropertyName("beamWidth_")]
    public float BeamWidth { get; set; } = 4f;

    [JsonPropertyName("beamLength_")]
    public float BeamLength { get; set; } = 60f;

    [JsonPropertyName("isBurstCounter_")]
    public bool IsBurstCounter { get; set; } = false;

    [JsonPropertyName("isTargetHoming_")]
    public bool IsTargetHoming { get; set; } = false;

    [JsonPropertyName("baseOffsetPos_")]
    public Vector4 BaseOffsetPos { get; set; } = new Vector4(0f, 0f, 8f, 1f);

    [JsonPropertyName("actionEndIntervalSec_")]
    public float ActionEndIntervalSec { get; set; } = 4f;

    [JsonPropertyName("skillNameLabel_")]
    public string SkillNameLabel { get; set; } = "TXT_BT_8400_5";

    [JsonPropertyName("cameraResetIntervalSec_")]
    public float CameraResetIntervalSec { get; set; } = 5f;

    [JsonPropertyName("attackDelayFrame_")]
    public int AttackDelayFrame { get; set; } = 7;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    public class BeamParameter /* Em8400AtkBeamAction::BeamParameter */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        [JsonPropertyName("delayFrame_")]
        public float DelayFrame { get; set; }
    }
}

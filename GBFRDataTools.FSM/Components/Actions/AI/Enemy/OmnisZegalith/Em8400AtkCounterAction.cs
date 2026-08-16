using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Entities;

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
public class Em8400AtkCounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkCounterAction);

    [JsonPropertyName("attackAreaParams_")]
    public BindingList<AttackAreaParam> AttackAreaParams { get; set; } = []; // std::vector<BT::Em8400AtkCounterAction::AttackAreaParam>

    [JsonPropertyName("basePosOffset_")]
    public Vector4 BasePosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("offsetValueArrayList_")]
    public BindingList<BindingList<int>> OffsetValueArrayList { get; set; } = []; // std::vector<std::array<int,10>>

    [JsonPropertyName("offsetDistance_")]
    public float OffsetDistance { get; set; } = 15f;

    [JsonPropertyName("shotRapidFrame_")]
    public int ShotRapidFrame { get; set; } = 10;

    [JsonPropertyName("rapidAttackStartDelayFrame_")]
    public int RapidAttackStartDelayFrame { get; set; } = 205;

    [JsonPropertyName("circleSeRadiusMax_")]
    public float CircleSeRadiusMax { get; set; } = 55f;

    [JsonPropertyName("circleSeScaleSec_")]
    public float CircleSeScaleSec { get; set; } = 1.5f;

    [JsonPropertyName("waveAtkRate_")]
    public float WaveAtkRate { get; set; } = 1f;

    [JsonPropertyName("waveStartRad_")]
    public float WaveStartRad { get; set; } = 6.5f;

    [JsonPropertyName("waveEndRad_")]
    public float WaveEndRad { get; set; } = 70f;

    [JsonPropertyName("waveScaleTimeSec_")]
    public float WaveScaleTimeSec { get; set; } = 1.72f;

    public class AttackAreaParam /* Em8400AtkCounterAction::AttackAreaParam */
    {
        [JsonPropertyName("posParam_")]
        public EmPositionParam PosParam { get; set; }
    
        [JsonPropertyName("rotateY_")]
        public float RotateY { get; set; }
    
        [JsonPropertyName("size_")]
        public Vector4 Size { get; set; }
    
        [JsonPropertyName("delay_")]
        public float Delay { get; set; }
    }
}

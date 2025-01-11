using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl0400Param : PlayerParameterInfo
{
    [JsonPropertyName("fastCastAcceptSec_")]
    public float FastCastAcceptSec { get; set; }

    [JsonPropertyName("fastCastRate_")]
    public float FastCastRate { get; set; }

    [JsonPropertyName("fastCastKeepSec_")]
    public float FastCastKeepSec { get; set; }

    [JsonPropertyName("targetMarkerScaleArray_")]
    public BindingList<float> TargetMarkerScaleArray { get; set; } = []; // std::array<float,5>

    [JsonPropertyName("linkAtkParam_")]
    public BindingList<Pl0400LinkAtkParam> LinkAtkParam { get; set; } = []; // std::array<Pl0400Param::Pl0400LinkAtkParam,2>

    [JsonPropertyName("fireAreaTimer_")]
    public float FireAreaTimer { get; set; }

    [JsonPropertyName("fireAtkWaitTime_")]
    public float FireAtkWaitTime { get; set; }

    [JsonPropertyName("fireInnerCircleSize_")]
    public float FireInnerCircleSize { get; set; }

    [JsonPropertyName("fireOuterCircleSize_")]
    public float FireOuterCircleSize { get; set; }

    [JsonPropertyName("fireAreaHeight_")]
    public float FireAreaHeight { get; set; }

    [JsonPropertyName("fireAreaAtkInterval_")]
    public float FireAreaAtkInterval { get; set; }

    [JsonPropertyName("tempCollisionSizeNormal_")]
    public float TempCollisionSizeNormal { get; set; }

    [JsonPropertyName("tempCollisionSizeBoss_")]
    public float TempCollisionSizeBoss { get; set; }

    [JsonPropertyName("stargazeLv1_DamageLimitRate_")]
    public float StargazeLv1_DamageLimitRate { get; set; }

    [JsonPropertyName("stargazeLv2_DamageLimitRate_")]
    public float StargazeLv2_DamageLimitRate { get; set; }

    [JsonPropertyName("stargazeLv3_DamageLimitRate_")]
    public float StargazeLv3_DamageLimitRate { get; set; }

    [JsonPropertyName("stargazeLv4_DamageLimitRate_")]
    public float StargazeLv4_DamageLimitRate { get; set; }

    [JsonPropertyName("stargazeLv5_DamageLimitRate_")]
    public float StargazeLv5_DamageLimitRate { get; set; }

    public class Pl0400LinkAtkParam // Pl0400Param::Pl0400LinkAtkParam
    {
        [JsonPropertyName("atkRad_")]
        public float AtkRad { get; set; }

        [JsonPropertyName("atkRate_")]
        public float AtkRate { get; set; }

        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; }

        [JsonPropertyName("spArtsRate_")]
        public float SpArtsRate { get; set; }

        [JsonPropertyName("hitStop_")]
        public int HitStop { get; set; }

        [JsonPropertyName("startFrame_")]
        public float StartFrame { get; set; }

        [JsonPropertyName("endFrame_")]
        public float EndFrame { get; set; }

        [JsonPropertyName("hitClearFrame_")]
        public float HitClearFrame { get; set; }
    }
}

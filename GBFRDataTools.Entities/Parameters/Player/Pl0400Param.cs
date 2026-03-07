using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Player;

using static GBFRDataTools.Entities.Parameters.Player.Pl0500Param;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0400Param : PlayerParameterInfo
{
    [JsonPropertyName("fastCastAcceptSec_")]
    public float FastCastAcceptSec { get; set; } = 0.5f;

    [JsonPropertyName("fastCastRate_")]
    public float FastCastRate { get; set; } = 0.6f;

    [JsonPropertyName("fastCastKeepSec_")]
    public float FastCastKeepSec { get; set; } = 0.25f;

    [JsonPropertyName("targetMarkerScaleArray_")]
    [Editable(false)]
    public BindingList<float> TargetMarkerScaleArray { get; set; } = [.. Enumerable.Repeat(0, 5).ToList()]; // std::array<float,5>

    [JsonPropertyName("linkAtkParam_")]
    public BindingList<Pl0400LinkAtkParam> LinkAtkParam { get; set; } = [.. Enumerable.Repeat(new Pl0400LinkAtkParam(), 2).ToList()]; // std::array<Pl0400Param::Pl0400LinkAtkParam,2>

    [JsonPropertyName("fireAreaTimer_")]
    public float FireAreaTimer { get; set; } = 10f;

    [JsonPropertyName("fireAtkWaitTime_")]
    public float FireAtkWaitTime { get; set; } = 1f;

    [JsonPropertyName("fireInnerCircleSize_")]
    public float FireInnerCircleSize { get; set; } = 4.5f;

    [JsonPropertyName("fireOuterCircleSize_")]
    public float FireOuterCircleSize { get; set; } = 5.1f;

    [JsonPropertyName("fireAreaHeight_")]
    public float FireAreaHeight { get; set; } = 1f;

    [JsonPropertyName("fireAreaAtkInterval_")]
    public float FireAreaAtkInterval { get; set; } = 1f;

    [JsonPropertyName("tempCollisionSizeNormal_")]
    public float TempCollisionSizeNormal { get; set; } = 0.75f;

    [JsonPropertyName("tempCollisionSizeBoss_")]
    public float TempCollisionSizeBoss { get; set; } = 1.5f;

    [JsonPropertyName("stargazeLv1_DamageLimitRate_")]
    public float StargazeLv1_DamageLimitRate { get; set; } = 100f;

    [JsonPropertyName("stargazeLv2_DamageLimitRate_")]
    public float StargazeLv2_DamageLimitRate { get; set; } = 200f;

    [JsonPropertyName("stargazeLv3_DamageLimitRate_")]
    public float StargazeLv3_DamageLimitRate { get; set; } = 350f;

    [JsonPropertyName("stargazeLv4_DamageLimitRate_")]
    public float StargazeLv4_DamageLimitRate { get; set; } = 600f;

    [JsonPropertyName("stargazeLv5_DamageLimitRate_")]
    public float StargazeLv5_DamageLimitRate { get; set; } = 1000f;

    public Pl0400Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        MaxLvHp = 30000;
        MaxLvAtk = 240;
        MaxLvDef = 1.05f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 9f;
        LimitSpecialArtsDamageRate = 0.6f;
        LimitAbilityDamageRate = 1.3f;
        AiMoveNotargetDistance = 22f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 39999;
        DamageLimitSpecialAttack = 29999;
        DamageLimitAbility01 = 1;
        DamageLimitAbility02 = 9999;
        DamageLimitAbility03 = 69999;
        DamageLimitAbility04 = 19999;
        DamageLimitAbility05 = 54999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 69999;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 16666;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 34999;
    }

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl1600Param : PlayerParameterInfo
{
    [JsonPropertyName("justJumpAtkRateIncrease_")]
    public float JustJumpAtkRateIncrease { get; set; } = 0.09999999f;

    [JsonPropertyName("justJumpBreakRateIncrease_")]
    public float JustJumpBreakRateIncrease { get; set; } = 0.15f;

    [JsonPropertyName("airRushSafetyTimer_")]
    public float AirRushSafetyTimer { get; set; } = 0.6f;

    [JsonPropertyName("laserAtkPow_")]
    public float LaserAtkPow { get; set; } = 0.7f;

    [JsonPropertyName("laserAtkBreak_")]
    public float LaserAtkBreak { get; set; } = 0.3f;

    [JsonPropertyName("laserAtkSpRate_")]
    public float LaserAtkSpRate { get; set; } = 0.25f;

    [JsonPropertyName("laserHitFrame_")]
    public float LaserHitFrame { get; set; } = 4f;

    [JsonPropertyName("laserHitCount_")]
    public int LaserHitCount { get; set; } = 6;

    [JsonPropertyName("rapidInputCancelFrame_")]
    public float RapidInputCancelFrame { get; set; } = 15f;

    [JsonPropertyName("justInputFrameBase_")]
    public int JustInputFrameBase { get; set; } = 10;

    [JsonPropertyName("nearCounterDist_")]
    public float NearCounterDist { get; set; } = 7f;

    [JsonPropertyName("airAtkCancelDist_")]
    public float AirAtkCancelDist { get; set; } = 1.5f;

    [JsonPropertyName("arvessCrtBuffRate_")]
    public float ArvessCrtBuffRate { get; set; } = 30f;

    [JsonPropertyName("preInputAcceptFrame_")]
    public int PreInputAcceptFrame { get; set; } = 15;

    [JsonPropertyName("forceFallAddSpeedRate_")]
    public float ForceFallAddSpeedRate { get; set; } = 2f;

    [JsonPropertyName("arvessAmplifyDamage_")]
    public float ArvessAmplifyDamage { get; set; } = 5f;

    public Pl1600Param()
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
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 22999;
        DamageLimitNormalAttack2 = 99999;
        DamageLimitSpecialAttack = 59999;
        DamageLimitAbility01 = 6999;
        DamageLimitAbility02 = 14999;
        DamageLimitAbility03 = 44999;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 49999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 29999;
        DamageLimitAbility08 = 54999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 39999;
    }
}

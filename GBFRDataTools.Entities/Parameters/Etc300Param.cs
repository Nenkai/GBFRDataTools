using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Etc300Param : PlayerParameterInfo
{
    [JsonPropertyName("hpMax_")]
    public int HpMax { get; set; } = 65535;

    [JsonPropertyName("hpMaxByUltimate_")]
    public int HpMaxByUltimate { get; set; } = 65535;

    [JsonPropertyName("atkPow_")]
    public int AtkPow { get; set; } = 45;

    [JsonPropertyName("atkPowByUltimate_")]
    public int AtkPowByUltimate { get; set; } = 4500;

    [JsonPropertyName("camRate_")]
    public float CamRate { get; set; } = 0.3f;

    [JsonPropertyName("camSpeed_")]
    public float CamSpeed { get; set; } = 0.5f;

    [JsonPropertyName("shotLineCheckOffsetDist_")]
    public float ShotLineCheckOffsetDist { get; set; } = 12.5f;

    [JsonPropertyName("machineGunInterval_")]
    public float MachineGunInterval { get; set; } = 5f;

    [JsonPropertyName("coolTimeRate_")]
    public float CoolTimeRate { get; set; } = 0.5f;

    [JsonPropertyName("missileLockMaxNum_")]
    public int MissileLockMaxNum { get; set; } = 15;

    [JsonPropertyName("missileLockIntervalTime_")]
    public float MissileLockIntervalTime { get; set; } = 0.15f;

    [JsonPropertyName("missileShotInterval_")]
    public float MissileShotInterval { get; set; } = 0.1f;

    [JsonPropertyName("laserMaxLevel_")]
    public int LaserMaxLevel { get; set; } = 1;

    [JsonPropertyName("laserChargeTime_")]
    public float LaserChargeTime { get; set; } = 2f;

    [JsonPropertyName("barrierTime_")]
    public float BarrierTime { get; set; } = 8f;

    [JsonPropertyName("isDrawDebugAim_")]
    public bool IsDrawDebugAim { get; set; } = false;

    [JsonPropertyName("aimPosOffsetX_")]
    public float AimPosOffsetX { get; set; } = 90f;

    [JsonPropertyName("aimPosOffsetY_")]
    public float AimPosOffsetY { get; set; } = 20f;

    [JsonPropertyName("recoveryTime_")]
    public float RecoveryTime { get; set; } = 0f;

    public Etc300Param()
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
        MaxLvDef = 2f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 9999;
        DamageLimitSpecialAttack = 9999;
        DamageLimitAbility01 = 99999;
        DamageLimitAbility02 = 99999;
        DamageLimitAbility03 = 99999;
        DamageLimitAbility04 = 99999;
        DamageLimitAbility05 = 99999;
        DamageLimitAbility06 = 99999;
        DamageLimitAbility07 = 99999;
        DamageLimitAbility08 = 99999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 99999;
    }
}
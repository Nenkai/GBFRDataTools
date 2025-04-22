using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Player;

public class DamageCalculateParam
{
    [JsonPropertyName("enmityCurve_")]
    public GuiImportableCurve<float> EnmityCurve { get; set; } = new GuiImportableCurve<float>() { Params = [0, 1] };

    [JsonPropertyName("staminaCurve_")]
    public GuiImportableCurve<float> StaminaCurve { get; set; } = new GuiImportableCurve<float>() { Params = [0, 1] };

    [JsonPropertyName("garrisonCurve_")]
    public GuiImportableCurve<float> GarrisonCurve { get; set; } = new GuiImportableCurve<float>() { Params = [0, 1] };

    [JsonPropertyName("smiteCurve_")]
    public GuiImportableCurve<float> SmiteCurve { get; set; } = new GuiImportableCurve<float>() { Params = [0, 1] };

    [JsonPropertyName("conceitCurve_")]
    public GuiImportableCurve<float> ConceitCurve { get; set; } = new GuiImportableCurve<float>() { Params = [0, 1] };

    [JsonPropertyName("skill233Curve_")]
    public GuiImportableCurve<float> Skill233Curve { get; set; } = new GuiImportableCurve<float>() { Params = [0, 1] };

    [JsonPropertyName("skill234Curve_")]
    public GuiImportableCurve<float> Skill234Curve { get; set; } = new GuiImportableCurve<float>() { Params = [0, 1] };

    [JsonPropertyName("smiteAttackRateMax_")]
    public float SmiteAttackRateMax { get; set; } = 10.0f;

    [JsonPropertyName("smiteAttackRateMin_")]
    public float SmiteAttackRateMin { get; set; } = 1.0f;

    [JsonPropertyName("criticalDamageUpperRate_")]
    public float CriticalDamageUpperRate { get; set; } = 50f;

    [JsonPropertyName("superArmorDamageRate_")]
    public float SuperArmorDamageRate { get; set; } = 50f;

    [JsonPropertyName("slowRateToFrostbite_")]
    public float SlowRateToFrostbite { get; set; } = 85.0f;

    [JsonPropertyName("slowRateToSlow_")]
    public float SlowRateToSlow { get; set; } = 70.0f;

    [JsonPropertyName("drainValueLimitBySkill_")]
    public int DrainValueLimitBySkill { get; set; } = 2000;

    [JsonPropertyName("drainValueLimitByBuff_")]
    public int DrainValueLimitByBuff { get; set; } = 1000;

    [JsonPropertyName("drainValueLimitByAction_Pl0900Attack_")]
    public int DrainValueLimitByAction_Pl0900Attack { get; set; } = 5000;

    [JsonPropertyName("drainValueLimitByAction_HeroicBeat_")]
    public int DrainValueLimitByAction_HeroicBeat { get; set; } = 5000;

    [JsonPropertyName("drainValueLimitByAction_ViolentShadows_")]
    public int DrainValueLimitByAction_ViolentShadows { get; set; } = 5000;

    [JsonPropertyName("drainValueLimitByAction_NeverEnough_")]
    public int DrainValueLimitByAction_NeverEnough { get; set; } = 5000;

    [JsonPropertyName("drainValueLimitByAction_NeverEnoughDragon_")]
    public int DrainValueLimitByAction_NeverEnoughDragon { get; set; } = 5000;

    [JsonPropertyName("drainValueLimitByAction_NeverEnoughSuper_")]
    public int DrainValueLimitByAction_NeverEnoughSuper { get; set; } = 5000;

    [JsonPropertyName("atkTypeDamageLimit_Normal_")]
    public float AtkTypeDamageLimit_Normal { get; set; } = 9999.0f;

    [JsonPropertyName("atkTypeDamageLimit_Ability_")]
    public float AtkTypeDamageLimit_Ability { get; set; } = 99999.0f;

    [JsonPropertyName("atkTypeDamageLimit_SpArts_")]
    public float AtkTypeDamageLimit_SpArts { get; set; } = 99999.0f;

    [JsonPropertyName("weakElementAddDamageRate_")]
    public float WeakElementAddDamageRate { get; set; } = 0.2f;
}
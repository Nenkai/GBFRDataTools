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

public class DamageCalculateParamFile
{
    [JsonPropertyName(nameof(DamageCalculateParam))]
    public DamageCalculateParam PresetList { get; set; }

    public static DamageCalculateParamFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        DamageCalculateParamFile paramFile = JsonSerializer.Deserialize<DamageCalculateParamFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class DamageCalculateParam
{
    [JsonPropertyName("enmityCurve_")]
    public GuiImportableCurve<float> EnmityCurve { get; set; }

    [JsonPropertyName("staminaCurve_")]
    public GuiImportableCurve<float> StaminaCurve { get; set; }

    [JsonPropertyName("garrisonCurve_")]
    public GuiImportableCurve<float> GarrisonCurve { get; set; }

    [JsonPropertyName("smiteCurve_")]
    public GuiImportableCurve<float> SmiteCurve { get; set; }

    [JsonPropertyName("conceitCurve_")]
    public GuiImportableCurve<float> ConceitCurve { get; set; }

    [JsonPropertyName("skill233Curve_")]
    public GuiImportableCurve<float> Skill233Curve { get; set; }

    [JsonPropertyName("skill234Curve_")]
    public GuiImportableCurve<float> Skill234Curve { get; set; }

    [JsonPropertyName("smiteAttackRateMax_")]
    public float SmiteAttackRateMax { get; set; }

    [JsonPropertyName("smiteAttackRateMin_")]
    public float SmiteAttackRateMin { get; set; }

    [JsonPropertyName("criticalDamageUpperRate_")]
    public float CriticalDamageUpperRate { get; set; }

    [JsonPropertyName("superArmorDamageRate_")]
    public float SuperArmorDamageRate { get; set; }

    [JsonPropertyName("slowRateToFrostbite_")]
    public float SlowRateToFrostbite { get; set; }

    [JsonPropertyName("slowRateToSlow_")]
    public float SlowRateToSlow { get; set; }

    [JsonPropertyName("drainValueLimitBySkill_")]
    public int DrainValueLimitBySkill { get; set; }

    [JsonPropertyName("drainValueLimitByBuff_")]
    public int DrainValueLimitByBuff { get; set; }

    [JsonPropertyName("drainValueLimitByAction_Pl0900Attack_")]
    public int DrainValueLimitByAction_Pl0900Attack { get; set; }

    [JsonPropertyName("drainValueLimitByAction_HeroicBeat_")]
    public int DrainValueLimitByAction_HeroicBeat { get; set; }

    [JsonPropertyName("drainValueLimitByAction_ViolentShadows_")]
    public int DrainValueLimitByAction_ViolentShadows { get; set; }

    [JsonPropertyName("drainValueLimitByAction_NeverEnough_")]
    public int DrainValueLimitByAction_NeverEnough { get; set; }

    [JsonPropertyName("drainValueLimitByAction_NeverEnoughDragon_")]
    public int DrainValueLimitByAction_NeverEnoughDragon { get; set; }

    [JsonPropertyName("drainValueLimitByAction_NeverEnoughSuper_")]
    public int DrainValueLimitByAction_NeverEnoughSuper { get; set; }

    [JsonPropertyName("atkTypeDamageLimit_Normal_")]
    public float AtkTypeDamageLimit_Normal { get; set; }

    [JsonPropertyName("atkTypeDamageLimit_Ability_")]
    public float AtkTypeDamageLimit_Ability { get; set; }

    [JsonPropertyName("atkTypeDamageLimit_SpArts_")]
    public float AtkTypeDamageLimit_SpArts { get; set; }

    [JsonPropertyName("weakElementAddDamageRate_")]
    public float WeakElementAddDamageRate { get; set; }
}
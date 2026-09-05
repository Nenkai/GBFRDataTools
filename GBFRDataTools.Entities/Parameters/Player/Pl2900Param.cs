using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Weapon.We2100;
using GBFRDataTools.Entities.Player;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Pl2900Param : PlayerParameterInfo
{
    [JsonPropertyName("maliceModeCameraOffset_")]
    public float MaliceModeCameraOffset { get; set; } = 3f;

    [JsonPropertyName("maliceModeCameraHeightOffset_")]
    public float MaliceModeCameraHeightOffset { get; set; } = 1.5f;

    [JsonPropertyName("maliceGageHit_")]
    public float MaliceGageHit { get; set; } = 150f;

    [JsonPropertyName("maliceGageAutoDecrease_")]
    public float MaliceGageAutoDecrease { get; set; } = 1f;

    [JsonPropertyName("maliceGageAutoDecreaseStartTime_")]
    public float MaliceGageAutoDecreaseStartTime { get; set; } = 0.5f;

    [JsonPropertyName("maliceGageAutoDecreaseStopTime_")]
    public float MaliceGageAutoDecreaseStopTime { get; set; } = 0.5f;

    [JsonPropertyName("maliceGageAutoDecreaseMax_")]
    public float MaliceGageAutoDecreaseMax { get; set; } = 10f;

    [JsonPropertyName("maliceGageAutoDecreaseAccelTime_")]
    public float MaliceGageAutoDecreaseAccelTime { get; set; } = 3f;

    [JsonPropertyName("eyeEmissiveRate_")]
    public float EyeEmissiveRate { get; set; } = 0.35f;

    [JsonPropertyName("isEyeHighlightRemoveOnEmissive_")]
    public bool IsEyeHighlightRemoveOnEmissive { get; set; } = true;

    [JsonPropertyName("stepMovementSpeed_")]
    public float StepMovementSpeed { get; set; } = 4f;

    [JsonPropertyName("ability08ChargeTime_Lv1_")]
    public float Ability08ChargeTime_Lv1 { get; set; } = 1.02f;

    [JsonPropertyName("ability08ChargeTime_Lv2_")]
    public float Ability08ChargeTime_Lv2 { get; set; } = 2.03f;

    [JsonPropertyName("ability08ChargeTime_Lv3_")]
    public float Ability08ChargeTime_Lv3 { get; set; } = 4.5f;

    [JsonPropertyName("ability08ChargeTime_ShortRate_")]
    public float Ability08ChargeTime_ShortRate { get; set; } = 0.5f;

    [JsonPropertyName("ability08CreateOffset_")]
    public Vector4 Ability08CreateOffset { get; set; } = new Vector4(-0.4f, 7f, -0.2f, 1f);

    [JsonPropertyName("ability08LoopOffsetY_")]
    public float Ability08LoopOffsetY { get; set; } = 3.2f;

    [JsonPropertyName("ability08Lv1Offset_")]
    public Vector4 Ability08Lv1Offset { get; set; } = new Vector4(0f, 0.4f, 0f, 1f);

    [JsonPropertyName("ability08Lv2Offset_")]
    public Vector4 Ability08Lv2Offset { get; set; } = new Vector4(0f, 1.5f, 0f, 1f);

    [JsonPropertyName("linkTimeAttackUpRate_")]
    public float LinkTimeAttackUpRate { get; set; } = 20f;

    [JsonPropertyName("linkTimeDamageLimitUpRate_")]
    public float LinkTimeDamageLimitUpRate { get; set; } = 30f;

    [JsonPropertyName("spArtsEmissiveData_")]
    public BindingList<SpArtsEmissiveData_> SpArtsEmissiveData { get; set; } = []; // std::vector<Pl2900Param::SpArtsEmissiveData>

    [JsonPropertyName("closeShotModeDistance_")]
    public float CloseShotModeDistance { get; set; } = 8.5f;

    [JsonPropertyName("targetSelectParam_")]
    public PlayerLockOnParameter TargetSelectParam { get; set; } = new();

    public Pl2900Param()
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
        DamageLimitMin = 9999;
        DamageLimitMax = 9999;
        AtkRateMin = 1f;
        AtkRateMax = 1f;
        IsSetExtraWeaponMotion = false;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SpArtsEmissiveData_ /* Pl2900Param::SpArtsEmissiveData */
    {
        [JsonPropertyName("frame_")]
        public int Frame { get; set; }

        [JsonPropertyName("emissivePower_")]
        public float EmissivePower { get; set; }
    }
}
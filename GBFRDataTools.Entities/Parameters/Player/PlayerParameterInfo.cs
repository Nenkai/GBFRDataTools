using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.Entities.Parameters.Player.PlayerParameterInfo;

namespace GBFRDataTools.Entities.Parameters.Player;

public class PlayerParameterInfo : CharaParameterBase
{
    [JsonPropertyName("maxLvHp_")]
    public int MaxLvHp { get; set; }

    [JsonPropertyName("maxLvAtk_")]
    public int MaxLvAtk { get; set; }

    [JsonPropertyName("maxLvDef_")]
    public float MaxLvDef { get; set; }

    [JsonPropertyName("maxLvExp_")]
    public int MaxLvExp { get; set; }

    [JsonPropertyName("criticalBaseRate_")]
    public float CriticalBaseRate { get; set; }

    [JsonPropertyName("baseBreakPower_")]
    public int BaseBreakPower { get; set; }

    [JsonPropertyName("limitDamageRate_")]
    public float LimitDamageRate { get; set; }

    [JsonPropertyName("limitSpecialArtsDamageRate_")]
    public float LimitSpecialArtsDamageRate { get; set; }

    [JsonPropertyName("limitAbilityDamageRate_")]
    public float LimitAbilityDamageRate { get; set; }

    [JsonPropertyName("aiMoveNotargetDistance_")]
    public float AiMoveNotargetDistance { get; set; }

    [JsonPropertyName("damageLimitMin_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int DamageLimitMin { get; set; }

    [JsonPropertyName("damageLimitMax_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int DamageLimitMax { get; set; }

    [JsonPropertyName("atkRateMin_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AtkRateMin { get; set; }

    [JsonPropertyName("atkRateMax_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AtkRateMax { get; set; }

    [JsonPropertyName("damageLimitNormalAttack_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitNormalAttack { get; set; }

    [JsonPropertyName("damageLimitNormalAttack2_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitNormalAttack2 { get; set; }

    [JsonPropertyName("damageLimitSpecialAttack_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitSpecialAttack { get; set; }

    [JsonPropertyName("damageLimitAbility01_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility01 { get; set; }

    [JsonPropertyName("damageLimitAbility02_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility02 { get; set; }

    [JsonPropertyName("damageLimitAbility03_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility03 { get; set; }

    [JsonPropertyName("damageLimitAbility04_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility04 { get; set; }

    [JsonPropertyName("damageLimitAbility05_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility05 { get; set; }

    [JsonPropertyName("damageLimitAbility06_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility06 { get; set; }

    [JsonPropertyName("damageLimitAbility07_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility07 { get; set; }

    [JsonPropertyName("damageLimitAbility08_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitAbility08 { get; set; }

    [JsonPropertyName("damageLimitLinkAttack_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitLinkAttack { get; set; }

    [JsonPropertyName("damageLimitSpecialArtsStart_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitSpecialArtsStart { get; set; }

    [JsonPropertyName("damageLimitSpecialArts_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public int DamageLimitSpecialArts { get; set; }

    [JsonPropertyName("damageLimitDataList_")]
    public PlayerDamageLimitParameter DamageLimitDataList { get; set; } = new();

    [JsonPropertyName("weaponAnimSetDataList_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public BindingList<WeaponAnimSetData> WeaponAnimSetDataList { get; set; } = [];

    [JsonPropertyName("isSetExtraWeaponMotion_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsSetExtraWeaponMotion { get; set; }

    [JsonPropertyName("eyeCtrlParam_")]
    [Obsolete("Removed in Endless Ragnarok")]
    public EyeControlParam EyeCtrlParam { get; set; } = new();

    public class WeaponAnimSetData /* PlayerParameterInfo::WeaponAnimSetData */
    {
        [JsonPropertyName("actionName_")]
        public string? ActionName { get; set; }

        [JsonPropertyName("keyAnimationName_")]
        public string? KeyAnimationName { get; set; }

        [JsonPropertyName("animationList_")]
        public BindingList<WeaponAnimationData> AnimationList { get; set; } = [];
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WeaponAnimationData /* PlayerParameterInfo::WeaponAnimationData */
    {
        [JsonPropertyName("animationName_")]
        public string? AnimationName { get; set; }

        [JsonPropertyName("offsetPosition_")]
        public Vector4 OffsetPosition { get; set; }

        [JsonPropertyName("weaponType_")]
        public int WeaponType { get; set; }

        [JsonPropertyName("actionType_")]
        public int ActionType { get; set; }

        [JsonPropertyName("freeWork_")]
        public int FreeWork { get; set; }

        [JsonPropertyName("maxRange_")]
        public float MaxRange { get; set; }

        [JsonPropertyName("actionFreeWork01_")]
        public float ActionFreeWork01 { get; set; }

        [JsonPropertyName("actionFreeWork02_")]
        public float ActionFreeWork02 { get; set; }

        [JsonPropertyName("actionFreeWork03_")]
        public float ActionFreeWork03 { get; set; }

        [JsonPropertyName("actionFreeWork04_")]
        public float ActionFreeWork04 { get; set; }
    }
}
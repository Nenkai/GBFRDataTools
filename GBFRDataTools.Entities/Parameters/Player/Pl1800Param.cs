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

public class Pl1800Param : PlayerParameterInfo
{
    [JsonPropertyName("weaponSetDataList_")]
    public BindingList<WeaponSetData> WeaponSetDataList { get; set; } = [];

    [JsonPropertyName("faceChangeDataList_")]
    public BindingList<FaceChangeData> FaceChangeDataList { get; set; } = [];

    [JsonPropertyName("linkAttackPowerUpRate_")]
    public float LinkAttackPowerUpRate { get; set; } = 0.09999999f;

    [JsonPropertyName("limitBonusAddStatusRate_Lv1_")]
    public float LimitBonusAddStatusRate_Lv1 { get; set; } = 0.07f;

    [JsonPropertyName("limitBonusAddStatusRate_Lv2_")]
    public float LimitBonusAddStatusRate_Lv2 { get; set; } = 0.14f;

    [JsonPropertyName("limitBonusAddStatusRate_Lv3_")]
    public float LimitBonusAddStatusRate_Lv3 { get; set; } = 0.2f;

    [JsonPropertyName("reviveHealHpRate_")]
    public float ReviveHealHpRate { get; set; } = 50f;

    [JsonPropertyName("linkTimeAtkRate_")]
    public float LinkTimeAtkRate { get; set; } = 0.2f;

    [JsonPropertyName("linkTimeDamageLimit_")]
    public float LinkTimeDamageLimit { get; set; } = 0.3999999f;

    public Pl1800Param()
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
        LimitSpecialArtsDamageRate = 0.7999999f;
        LimitAbilityDamageRate = 0.7999999f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 1999;
        DamageLimitSpecialAttack = 14999;
        DamageLimitAbility01 = 69999;
        DamageLimitAbility02 = 39999;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 19999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 34999;
        DamageLimitAbility08 = 44999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 19999;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WeaponSetData
    {
        [JsonPropertyName("keyAnimationName_")]
        public string KeyAnimationName { get; set; } // Offset 0x8

        [JsonPropertyName("weaponType_")]
        public int WeaponType { get; set; } // Offset 0x28

        [JsonPropertyName("isFallAttackMode_")]
        public bool IsFallAttackMode { get; set; } // Offset 0x2C

        [JsonPropertyName("isGroundCheck_")]
        public bool IsGroundCheck { get; set; } // Offset 0x2D

        [JsonPropertyName("animationList_")]
        public BindingList<WeaponMotionData> AnimationList { get; set; } = []; // Offset 0x30

        public WeaponSetData()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WeaponMotionData
    {
        [JsonPropertyName("animationName_")]
        public string AnimationName { get; set; } // Offset 0x10

        [JsonPropertyName("offsetPosition_")]
        public Vector4 OffsetPosition { get; set; } // Offset 0x30

        public WeaponMotionData()
        {
        }
    }


    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FaceChangeData
    {
        [JsonPropertyName("actionId_")]
        public int ActionId { get; set; } // Offset 0x8

        [JsonPropertyName("faceType_")]
        public int FaceType { get; set; } // Offset 0xC

        public FaceChangeData()
        {
        }
    }
}

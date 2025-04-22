using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmBossBaseParam : EnemyParameterInfo
{
    [JsonPropertyName("overDriveParam_")]
    public OverDriveParam OverDriveParam_ { get; set; }

    [JsonPropertyName("emissiveParamDefault_")]
    public CharacterEmissiveParam EmissiveParamDefault { get; set; }

    [JsonPropertyName("emissiveParamMax_")]
    public CharacterEmissiveParam EmissiveParamMax { get; set; }

    [JsonPropertyName("emissiveParamMin_")]
    public CharacterEmissiveParam EmissiveParamMin { get; set; }

    [JsonPropertyName("spArtsCutinParam_")]
    public SpecialArtsCutinParam SpArtsCutinParam { get; set; }

    [JsonPropertyName("odAbilityParam_")]
    public OdAbilityParam OdAbilityParam_ { get; set; }

    [JsonPropertyName("cameraLength_")]
    public float CameraLength { get; set; }

    [JsonPropertyName("odHitStopTimeRate_")]
    public float OdHitStopTimeRate { get; set; }

    [JsonPropertyName("breakHitStopTimeRate_")]
    public float BreakHitStopTimeRate { get; set; }

    [JsonPropertyName("emissiveInitValue_")]
    public float EmissiveInitValue { get; set; }

    [JsonPropertyName("odAttackRateFirstTime_")]
    public float OdAttackRateFirstTime { get; set; }

    [JsonPropertyName("odDefenseRateFirstTime_")]
    public float OdDefenseRateFirstTime { get; set; }

    [JsonPropertyName("odAttackRateSecondTime_")]
    public float OdAttackRateSecondTime { get; set; }

    [JsonPropertyName("odDefenseRateSecondTime_")]
    public float OdDefenseRateSecondTime { get; set; }

    [JsonPropertyName("abilityCoolSec_")]
    public float AbilityCoolSec { get; set; }

    [JsonPropertyName("isCutInDamageDisable_")]
    public bool IsCutInDamageDisable { get; set; }

    [JsonPropertyName("bossStunOffsetY_")]
    public float BossStunOffsetY { get; set; }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OverDriveParam // EmBossBaseParam::OverDriveParam
    {
        [JsonPropertyName("hpRateNormal_")]
        public float HpRateNormal { get; set; } = 0.2f;

        [JsonPropertyName("hpRateOverDrive_")]
        public float HpRateOverDrive { get; set; } = 0.2f;

        [JsonPropertyName("hpRateBreak_")]
        public float HpRateBreak { get; set; } = 0.2f;

        [JsonPropertyName("minBreakSecond_")]
        public float MinBreakSecond { get; set; } = 5.0f;

        [JsonPropertyName("forceBreakSecond_")]
        public float ForceBreakSecond { get; set; } = 20.0f;

        [JsonPropertyName("overDriveVyrnVoiceWaitSecond_")]
        public float OverDriveVyrnVoiceWaitSecond { get; set; } = 0.0f;

        [JsonPropertyName("overDriveCameraPartsNumber_")]
        public int OverDriveCameraPartsNumber { get; set; } = -1;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SpecialArtsCutinParam // EmBossBaseParam::SpecialArtsCutinParam
    {
        [JsonPropertyName("spArtsTextId_")]
        public string SpArtsTextId { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OdAbilityParam // EmBossBaseParam::OdAbilityParam
    {
        [JsonPropertyName("textId_")]
        public string TextId { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BossAttackParam // EmBossBaseParam::BossAttackParam
    {
        [JsonPropertyName("attackRateNormal_")]
        public float AttackRateNormal { get; set; }

        [JsonPropertyName("attackRateOverDrive_")]
        public float AttackRateOverDrive { get; set; }

        [JsonPropertyName("breakRateNormal_")]
        public float BreakRateNormal { get; set; }

        [JsonPropertyName("breakRateOverDrive_")]
        public float BreakRateOverDrive { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Vibration;

public class ApplicationVibrationParameter
{
    [JsonPropertyName("vibAttenuationDistanceList_")]
    public BindingList<DistanceInfo> VibAttenuationDistanceList { get; set; } = []; // std::vector<ApplicationVibrationParameter::DistanceInfo> Offset 0x8F0

    [JsonPropertyName("attackHitVibHitStopMax_")]
    public float AttackHitVibHitStopMax { get; set; } // Offset 0x7C

    [JsonPropertyName("attackHitVibHitStopBiasMin_")]
    public float AttackHitVibHitStopBiasMin { get; set; } // Offset 0x78

    [JsonPropertyName("bladeHitParameter_")]
    public VibrationInfo BladeHitParameter { get; set; } // Offset 0x8

    [JsonPropertyName("smashHitParameter_")]
    public VibrationInfo SmashHitParameter { get; set; } // Offset 0x40

    [JsonPropertyName("chainBurst_2Chain_Parameter_")]
    public VibrationInfo ChainBurst_2Chain_Parameter { get; set; } // Offset 0x80

    [JsonPropertyName("chainBurst_3Chain_Parameter_")]
    public VibrationInfo ChainBurst_3Chain_Parameter { get; set; } // Offset 0xB8

    [JsonPropertyName("chainBurst_FullChain_Parameter_")]
    public VibrationInfo ChainBurst_FullChain_Parameter { get; set; } // Offset 0xF0

    [JsonPropertyName("linkChance_Parameter_")]
    public VibrationInfo LinkChance_Parameter { get; set; } // Offset 0x128

    [JsonPropertyName("spArts_Max_Parameter_")]
    public VibrationInfo SpArts_Max_Parameter { get; set; } // Offset 0x160

    [JsonPropertyName("spChain_Parameter_")]
    public VibrationInfo SpChain_Parameter { get; set; } // Offset 0x198

    [JsonPropertyName("guardBreak_Parameter_")]
    public VibrationInfo GuardBreak_Parameter { get; set; } // Offset 0x1D0

    [JsonPropertyName("chargeLvIncrease_Lv1_Parameter_")]
    public VibrationInfo ChargeLvIncrease_Lv1_Parameter { get; set; } // Offset 0x208

    [JsonPropertyName("chargeLvIncrease_Lv2_Parameter_")]
    public VibrationInfo ChargeLvIncrease_Lv2_Parameter { get; set; } // Offset 0x240

    [JsonPropertyName("chargeLvIncrease_Lv3_Parameter_")]
    public VibrationInfo ChargeLvIncrease_Lv3_Parameter { get; set; } // Offset 0x278

    [JsonPropertyName("chargeLvIncrease_Lv4_Parameter_")]
    public VibrationInfo ChargeLvIncrease_Lv4_Parameter { get; set; } // Offset 0x2B0

    [JsonPropertyName("chargeFinish_Parameter_")]
    public VibrationInfo ChargeFinish_Parameter { get; set; } // Offset 0x2E8

    [JsonPropertyName("chargeLoopVibParameter_")]
    public VibrationInfo ChargeLoopVibParameter { get; set; } // Offset 0x320

    [JsonPropertyName("commonDamageParameter_")]
    public VibrationInfo CommonDamageParameter { get; set; } // Offset 0x360

    [JsonPropertyName("largeDamageHitStopParameter_")]
    public VibrationInfo LargeDamageHitStopParameter { get; set; } // Offset 0x398

    [JsonPropertyName("blowDamageParameter_")]
    public VibrationInfo BlowDamageParameter { get; set; } // Offset 0x3D0

    [JsonPropertyName("windReactionParameter_")]
    public VibrationInfo WindReactionParameter { get; set; } // Offset 0x408

    [JsonPropertyName("groundShakeReactionParameter_")]
    public VibrationInfo GroundShakeReactionParameter { get; set; } // Offset 0x440

    [JsonPropertyName("badStatusNoticeParameter_")]
    public VibrationInfo BadStatusNoticeParameter { get; set; } // Offset 0x478

    [JsonPropertyName("dieParameter_")]
    public VibrationInfo DieParameter { get; set; } // Offset 0x4B0

    [JsonPropertyName("crisisParameter_")]
    public VibrationInfo CrisisParameter { get; set; } // Offset 0x4E8

    [JsonPropertyName("downParameter_")]
    public VibrationInfo DownParameter { get; set; } // Offset 0x520

    [JsonPropertyName("wallHitParameter_")]
    public VibrationInfo WallHitParameter { get; set; } // Offset 0x558

    [JsonPropertyName("guardParameter_")]
    public VibrationInfo GuardParameter { get; set; } // Offset 0x590

    [JsonPropertyName("guardVibKnockBackBiasMin_")]
    public float GuardVibKnockBackBiasMin { get; set; } // Offset 0x5C8

    [JsonPropertyName("guardVibKnockBackMax_")]
    public float GuardVibKnockBackMax { get; set; } // Offset 0x5CC

    [JsonPropertyName("justAvoidParameter_")]
    public VibrationInfo JustAvoidParameter { get; set; } // Offset 0x5D0

    [JsonPropertyName("justGuardParameter_")]
    public VibrationInfo JustGuardParameter { get; set; } // Offset 0x608

    [JsonPropertyName("finishSlowParameter_")]
    public VibrationInfo FinishSlowParameter { get; set; } // Offset 0x640

    [JsonPropertyName("startLinkTimeParameter_")]
    public VibrationInfo StartLinkTimeParameter { get; set; } // Offset 0x6B0

    [JsonPropertyName("reviveFinishParameter_")]
    public VibrationInfo ReviveFinishParameter { get; set; } // Offset 0x6E8

    [JsonPropertyName("rescueParameter_")]
    public VibrationInfo RescueParameter { get; set; } // Offset 0x720

    [JsonPropertyName("linkAtatckHitParameter_")]
    public VibrationInfo LinkAtatckHitParameter { get; set; } // Offset 0x678

    [JsonPropertyName("throwObjectExplodedParameter_")]
    public VibrationInfo ThrowObjectExplodedParameter { get; set; } // Offset 0x760

    [JsonPropertyName("uniqueAttatckHitParameter_A_")]
    public VibrationInfo UniqueAttatckHitParameter_A { get; set; } // Offset 0x798

    [JsonPropertyName("uniqueAttatckHitParameter_B_")]
    public VibrationInfo UniqueAttatckHitParameter_B { get; set; } // Offset 0x7D0

    [JsonPropertyName("uniqueAttatckHitParameter_C_")]
    public VibrationInfo UniqueAttatckHitParameter_C { get; set; } // Offset 0x808

    [JsonPropertyName("uniqueAttatckHitParameter_D_")]
    public VibrationInfo UniqueAttatckHitParameter_D { get; set; } // Offset 0x840

    [JsonPropertyName("addBuffStatusParameter_")]
    public VibrationInfo AddBuffStatusParameter { get; set; } // Offset 0x878

    [JsonPropertyName("suctionVibParameter_")]
    public VibrationInfo SuctionVibParameter { get; set; } // Offset 0x8B0

    public ApplicationVibrationParameter()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DistanceInfo
    {
        [JsonPropertyName("distance_")]
        public float Distance { get; set; } // Offset 0x8

        [JsonPropertyName("attenuationRate_")]
        public float AttenuationRate { get; set; } // Offset 0xC
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class VibrationInfo
    {
        [JsonPropertyName("vibrationPower_")]
        public float VibrationPower { get; set; } // Offset 0x8

        [JsonPropertyName("vibrationSec_")]
        public float VibrationSec { get; set; } // Offset 0xC

        [JsonPropertyName("vibrationWaveEventName_")]
        public string VibrationWaveEventName { get; set; } // Offset 0x18

        [JsonPropertyName("vibrationWavePower_")]
        public float VibrationWavePower { get; set; } // Offset 0x10

        [JsonPropertyName("isEnableDistanceAttenuation_")]
        public bool IsEnableDistanceAttenuation { get; set; } // Offset 0x14

        public VibrationInfo()
        {
        }
    }
}

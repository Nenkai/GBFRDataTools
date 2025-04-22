using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class SpecialArtsParam
{
    [JsonPropertyName("AfterInvisibleSec")]
    public float AfterInvisibleSec { get; set; }

    [JsonPropertyName("SpArtsChainAddRate")]
    public float SpArtsChainAddRate { get; set; }

    [JsonPropertyName("AttackHitAddPoint")]
    public float AttackHitAddPoint { get; set; }

    [JsonPropertyName("DamageHitAddPoint")]
    public float DamageHitAddPoint { get; set; }

    [JsonPropertyName("DamageHitBonusPoint_HpHigh")]
    public float DamageHitBonusPoint_HpHigh { get; set; }

    [JsonPropertyName("DamageHitBonusPoint_HpLow")]
    public float DamageHitBonusPoint_HpLow { get; set; }

    [JsonPropertyName("ChainBurstATKRate_2Chain")]
    public float ChainBurstATKRate_2Chain { get; set; }

    [JsonPropertyName("ChainBurstATKRate_3Chain")]
    public float ChainBurstATKRate_3Chain { get; set; }

    [JsonPropertyName("ChainBurstATKRate_FullChain")]
    public float ChainBurstATKRate_FullChain { get; set; }

    [JsonPropertyName("CamAddLenTimer")]
    public float CamAddLenTimer { get; set; }

    [JsonPropertyName("CamAddLen")]
    public float CamAddLen { get; set; }

    [JsonPropertyName("CamAddRate")]
    public float CamAddRate { get; set; }

    [JsonPropertyName("CamAddLenLimit")]
    public float CamAddLenLimit { get; set; }

    [JsonPropertyName("TutorialAttackHitAddPoint")]
    public float TutorialAttackHitAddPoint { get; set; }

    [JsonPropertyName("NpcGageAddRate")]
    public float NpcGageAddRate { get; set; }

    [JsonPropertyName("NpcActivateEnemyHpRate_Single_")]
    public float NpcActivateEnemyHpRate_Single { get; set; }

    [JsonPropertyName("NpcActivateEnemyHpRate_2chain_")]
    public float NpcActivateEnemyHpRate_2chain { get; set; }

    [JsonPropertyName("NpcActivateEnemyHpRate_3chain_")]
    public float NpcActivateEnemyHpRate_3chain { get; set; }

    [JsonPropertyName("SpArtsAfterGagePenaltyRate_")]
    public float SpArtsAfterGagePenaltyRate { get; set; }

    [JsonPropertyName("SpArtsAfterGagePenaltySec_")]
    public float SpArtsAfterGagePenaltySec { get; set; }
}

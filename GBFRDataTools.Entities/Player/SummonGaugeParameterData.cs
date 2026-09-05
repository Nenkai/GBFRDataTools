using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GBFRDataTools.Entities.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonGaugeParameterData
{
    [JsonPropertyName("addPointLinkAttack")]
    public float AddPointLinkAttack { get; set; }

    [JsonPropertyName("addPointSpArts")]
    public float AddPointSpArts { get; set; }

    [JsonPropertyName("addPoint2ChainBurst")]
    public float AddPoint2ChainBurst { get; set; }

    [JsonPropertyName("addPoint3ChainBurst")]
    public float AddPoint3ChainBurst { get; set; }

    [JsonPropertyName("addPointFullChainBurst")]
    public float AddPointFullChainBurst { get; set; }

    [JsonPropertyName("addPointReviveFriend")]
    public float AddPointReviveFriend { get; set; }

    [JsonPropertyName("addPointUseAllPotion")]
    public float AddPointUseAllPotion { get; set; }

    [JsonPropertyName("summonEndInvinsibleSec")]
    public float SummonEndInvinsibleSec { get; set; }

    [JsonPropertyName("summonWeakElementDamageRate")]
    public float SummonWeakElementDamageRate { get; set; }

    [JsonPropertyName("skillBoardDamageRateUp")]
    public float SkillBoardDamageRateUp { get; set; }

    [JsonPropertyName("skillBoardDamageRateDown")]
    public float SkillBoardDamageRateDown { get; set; }

    [JsonPropertyName("skillBoardStatusEffectRateUp")]
    public float SkillBoardStatusEffectRateUp { get; set; }

    [JsonPropertyName("skillBoardStatusEffectRateDown")]
    public float SkillBoardStatusEffectRateDown { get; set; }

    [JsonPropertyName("skillBoardStatusTimeRateUp")]
    public float SkillBoardStatusTimeRateUp { get; set; }

    [JsonPropertyName("skillBoardStatusTimeRateDown")]
    public float SkillBoardStatusTimeRateDown { get; set; }

    [JsonPropertyName("skillBoardSlimeMoneyRateUp")]
    public float SkillBoardSlimeMoneyRateUp { get; set; }

    [JsonPropertyName("skillBoardSlimeMoneyRateDown")]
    public float SkillBoardSlimeMoneyRateDown { get; set; }

    [JsonPropertyName("skillBoardVillagerPotionUp")]
    public int SkillBoardVillagerPotionUp { get; set; }

    [JsonPropertyName("skillBoardMonkGaugeRateUp")]
    public float SkillBoardMonkGaugeRateUp { get; set; }

    [JsonPropertyName("skillBoardMonkGaugeRateDown")]
    public float SkillBoardMonkGaugeRateDown { get; set; }

    [JsonPropertyName("skillBoardGuildmarmGaugeRateUp")]
    public float SkillBoardGuildmarmGaugeRateUp { get; set; }

    [JsonPropertyName("skillBoardGuildmarmGaugeRateDown")]
    public float SkillBoardGuildmarmGaugeRateDown { get; set; }

    [JsonPropertyName("skillBoardRefereeDebuffTime")]
    public float SkillBoardRefereeDebuffTime { get; set; }

    [JsonPropertyName("skillBoardRefereeDebuffRate")]
    public float SkillBoardRefereeDebuffRate { get; set; }

    [JsonPropertyName("skillBoardRefereeStunRateDown")]
    public float SkillBoardRefereeStunRateDown { get; set; }

    [JsonPropertyName("skillBoardRouletteStatusTime")]
    public float SkillBoardRouletteStatusTime { get; set; }

    [JsonPropertyName("skillBoardRouletteAttackUpRate")]
    public float SkillBoardRouletteAttackUpRate { get; set; }

    [JsonPropertyName("skillBoardRouletteDoubleAttackRate")]
    public float SkillBoardRouletteDoubleAttackRate { get; set; }

    [JsonPropertyName("skillBoardRouletteAmplifyRate")]
    public float SkillBoardRouletteAmplifyRate { get; set; }
}
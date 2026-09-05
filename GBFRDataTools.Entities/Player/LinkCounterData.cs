using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

using GBFRDataTools.Entities.Base;
using System.ComponentModel;

namespace GBFRDataTools.Entities.Player;

public class LinkCounterData
{
    [JsonPropertyName("level0_")]
    public LinkCounterLevelData Level0 { get; set; } = new();

    [JsonPropertyName("level1_")]
    public LinkCounterLevelData Level1 { get; set; } = new();

    [JsonPropertyName("level2_")]
    public LinkCounterLevelData Level2 { get; set; } = new();

    [JsonPropertyName("level3_")]
    public LinkCounterLevelData Level3 { get; set; } = new();

    [JsonPropertyName("level4_")]
    public LinkCounterLevelData Level4 { get; set; } = new();

    [JsonPropertyName("level5_")]
    public LinkCounterLevelData Level5 { get; set; } = new();

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

    [JsonPropertyName("addPointAbilityUse_Min")]
    public float AddPointAbilityUse_Min { get; set; }

    [JsonPropertyName("addPointAbilityUse_Max")]
    public float AddPointAbilityUse_Max { get; set; }

    [JsonPropertyName("addPointReceptionistSummon")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointReceptionistSummon { get; set; }

    [JsonPropertyName("addPointLinkAttack_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointLinkAttack_Chaos { get; set; }

    [JsonPropertyName("addPointSpArts_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointSpArts_Chaos { get; set; }

    [JsonPropertyName("addPoint2ChainBurst_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPoint2ChainBurst_Chaos { get; set; }

    [JsonPropertyName("addPoint3ChainBurst_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPoint3ChainBurst_Chaos { get; set; }

    [JsonPropertyName("addPointFullChainBurst_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointFullChainBurst_Chaos { get; set; }

    [JsonPropertyName("addPointReviveFriend_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointReviveFriend_Chaos { get; set; }

    [JsonPropertyName("addPointUseAllPotion_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointUseAllPotion_Chaos { get; set; }

    [JsonPropertyName("addPointAbilityUse_Min_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointAbilityUse_Min_Chaos { get; set; }

    [JsonPropertyName("addPointAbilityUse_Max_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointAbilityUse_Max_Chaos { get; set; }

    [JsonPropertyName("addPointReceptionistSummon_Chaos")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float AddPointReceptionistSummon_Chaos { get; set; }

    [JsonPropertyName("baseAbilityCoolTime_Min")]
    public float BaseAbilityCoolTime_Min { get; set; }

    [JsonPropertyName("baseAbilityCoolTime_Max")]
    public float BaseAbilityCoolTime_Max { get; set; }

    [JsonPropertyName("stopAutoDecreaseSecAddPoint_")]
    public float StopAutoDecreaseSecAddPoint { get; set; }

    [JsonPropertyName("stopAutoDecreaseSecAddPoint_NoBattle_")]
    public float StopAutoDecreaseSecAddPoint_NoBattle { get; set; }

    [JsonPropertyName("linkTimeKeepSec_")]
    public float LinkTimeKeepSec { get; set; }

    [JsonPropertyName("linkTimeEnemySlowRate_")]
    public float LinkTimeEnemySlowRate { get; set; }

    [JsonPropertyName("linkTimeAbilityCoolTimeRecoverRate_")]
    public float LinkTimeAbilityCoolTimeRecoverRate { get; set; }

    [JsonPropertyName("linkTimeAttackBuffRate_")]
    public float LinkTimeAttackBuffRate { get; set; }

    [JsonPropertyName("linkTimeCriticalRate_")]
    public float LinkTimeCriticalRate { get; set; }

    [JsonPropertyName("linkTimeRecoverIntervalSec_")]
    public float LinkTimeRecoverIntervalSec { get; set; }

    [JsonPropertyName("linkTimeRecoverHpRate_")]
    public float LinkTimeRecoverHpRate { get; set; }

    [JsonPropertyName("linkTimeAttackHitExtendSec_")]
    public float LinkTimeAttackHitExtendSec { get; set; }

    [JsonPropertyName("linkTimeAttackHitExtendCoolTimeSec_")]
    public float LinkTimeAttackHitExtendCoolTimeSec { get; set; }

    [JsonPropertyName("linkTimeAttackHitExtendSec_Min_")]
    public float LinkTimeAttackHitExtendSec_Min { get; set; }

    [JsonPropertyName("linkTimeAttackHitExtendSec_Max_")]
    public float LinkTimeAttackHitExtendSec_Max { get; set; }

    [JsonPropertyName("linkTimeAttackHitExtendAtkRate_Min_")]
    public float LinkTimeAttackHitExtendAtkRate_Min { get; set; }

    [JsonPropertyName("linkTimeAttackHitExtendAtkRate_Max_")]
    public float LinkTimeAttackHitExtendAtkRate_Max { get; set; }

    [JsonPropertyName("linkTimeExtendAtkRateCurve_")]
    public GuiImportableCurve<float> LinkTimeExtendAtkRateCurve { get; set; } = new();

    [JsonPropertyName("linkTimeDecreaseSpeedUpSec_")]
    public float LinkTimeDecreaseSpeedUpSec { get; set; }

    [JsonPropertyName("linkTimeAccelEndSec_")]
    public float LinkTimeAccelEndSec { get; set; }

    [JsonPropertyName("linkTimeAccelSpeedRate_")]
    public float LinkTimeAccelSpeedRate { get; set; }

    [JsonPropertyName("linkTimeAddPointDecreaseSpeedUpSec_")]
    public float LinkTimeAddPointDecreaseSpeedUpSec { get; set; }

    [JsonPropertyName("linkTimeAddPointDecreaseSpeedAccelEndSec_")]
    public float LinkTimeAddPointDecreaseSpeedAccelEndSec { get; set; }

    [JsonPropertyName("linkTimeAddPointDecreaseSpeedAccelSpeedRate_")]
    public float LinkTimeAddPointDecreaseSpeedAccelSpeedRate { get; set; }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class LinkCounterLevelData
{
    [JsonPropertyName("pointMax_")]
    public string? PointMax { get; set; }

    [JsonPropertyName("decreasePoint_")]
    public string? DecreasePoint { get; set; }

    [JsonPropertyName("decreasePointNoBattle_")]
    public string? DecreasePointNoBattle { get; set; }

    [JsonPropertyName("rankAtkRate_")]
    public string? RankAtkRate { get; set; }
}

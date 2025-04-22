using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0000Param : Pl0100Param
{
    public Pl0000Param()
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
        LimitSpecialArtsDamageRate = 0.9f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 9999;
        DamageLimitSpecialAttack = 29999;
        DamageLimitAbility01 = 19999;
        DamageLimitAbility02 = 39999;
        DamageLimitAbility03 = 14999;
        DamageLimitAbility04 = 14999;
        DamageLimitAbility05 = 14999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 89999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 64999;
        ClassLvResetWaitSec = 3f;
        ClearAllRegenerateRateLv1 = 3f;
        ClearAllRegenerateRateLv2 = 3.5f;
        ClearAllRegenerateRateLv3 = 4f;
        ClearAllRegenerateRateLv4 = 4.5f;
        ClearAllRegenerateSecLv1 = 20f;
        ClearAllRegenerateSecLv2 = 20f;
        ClearAllRegenerateSecLv3 = 20f;
        ClearAllRegenerateSecLv4 = 20f;
        ReviveHealHpRateLv1 = 30f;
        ReviveHealHpRateLv2 = 50f;
        ReviveHealHpRateLv3 = 70f;
        ReviveHealHpRateLv4 = 100f;
        AbilityCoolTimeReduceSec = 1f;
    }
}

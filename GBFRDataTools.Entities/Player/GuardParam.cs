using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

using MessagePack;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Player;

public class GuardParam
{
    public float GuardGageMax { get; set; } = 5.0f;
    public float GuardStopHealSec { get; set; } = 5.0f;
    public float DamageStopHealSec { get; set; } = 12.0f;
    public float GuardPointStopHealSec { get; set; } = 10.0f;
    public float HelpGuardStopHealSec { get; set; } = 15.0f;
    public float GuardBreakSec { get; set; } = 20.0f;
    public float GuardAutoHealValue { get; set; } = 0.005f;
    public float GuardDamageCutRate { get; set; } = 0.0f;
    public float GuardBreakDamageCutRate { get; set; } = 0.3f;
    public float HelpGuardBreakGageRate { get; set; } = 2.0f;
    public float KnockBackRateMin { get; set; } = 0.25f;
    public float KnockBackRateMax { get; set; } = 0.9f;
    public float KnockBackJudgePowerMin { get; set; } = 0.0f;
    public float KnockBackJudgePowerMax { get; set; } = 0.3f;
    public float KnockBackGuardTurnRate { get; set; } = 0.7f;
    public float GuardPointBreakGageRate { get; set; } = 2.5f;
    public int JustGuardAcceptFrame { get; set; } = 5;
    public int ChargeParryAcceptFrame { get; set; } = 10;
    public float ChargeParryInvinsbleTime { get; set; } = 1.5f;
    public float JustGuardAttackBreakRate { get; set; } = 10.0f;
    public float JustGuardAttackSize { get; set; } = 2.0f;
    public /* cVec4 */ Vector4 JustGuardAttackOffset { get; set; } = new Vector4(0.0f, 1.0f, 1.4f, 1.0f);
    public float JustGuardPraiseVoiceIntervalSec { get; set; } = 10.0f;

    [JsonPropertyName("guardFailedPenaltyTime")]
    public float GuardFailedPenaltyTime { get; set; } = 0.5f;
}

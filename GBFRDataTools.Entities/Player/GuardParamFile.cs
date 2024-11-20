using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Player;

public class GuardParamFile
{
    [JsonPropertyName(nameof(GuardParam))]
    public GuardParam GuardParam { get; set; }

    public static GuardParamFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        GuardParamFile paramFile = JsonSerializer.Deserialize<GuardParamFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class GuardParam
{
    public float GuardGageMax { get; set; }
    public float GuardStopHealSec { get; set; }
    public float DamageStopHealSec { get; set; }
    public float GuardPointStopHealSec { get; set; }
    public float HelpGuardStopHealSec { get; set; }
    public float GuardBreakSec { get; set; }
    public float GuardAutoHealValue { get; set; }
    public float GuardDamageCutRate { get; set; }
    public float GuardBreakDamageCutRate { get; set; }
    public float HelpGuardBreakGageRate { get; set; }
    public float KnockBackRateMin { get; set; }
    public float KnockBackRateMax { get; set; }
    public float KnockBackJudgePowerMin { get; set; }
    public float KnockBackJudgePowerMax { get; set; }
    public float KnockBackGuardTurnRate { get; set; }
    public float GuardPointBreakGageRate { get; set; }
    public float JustGuardAcceptFrame { get; set; }
    public float ChargeParryAcceptFrame { get; set; }
    public float ChargeParryInvinsbleTime { get; set; }
    public float JustGuardAttackBreakRate { get; set; }
    public float JustGuardAttackSize { get; set; }
    public cVec4 JustGuardAttackOffset { get; set; }
    public float JustGuardPraiseVoiceIntervalSec { get; set; }
    public float guardFailedPenaltyTime { get; set; }
}

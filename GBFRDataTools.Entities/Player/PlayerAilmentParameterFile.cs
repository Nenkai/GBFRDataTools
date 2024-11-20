using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerAilmentParameterFile
{
    [JsonPropertyName(nameof(PlayerAilmentParameter))]
    public PlayerAilmentParameter PlayerAilmentParameter { get; set; }

    public static PlayerAilmentParameterFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        PlayerAilmentParameterFile paramFile = JsonSerializer.Deserialize<PlayerAilmentParameterFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class PlayerAilmentParameter
{
    [JsonPropertyName("frostbiteCoolTimeSec_")]
    public float FrostbiteCoolTimeSec { get; set; }

    [JsonPropertyName("restraintCoolTimeSec_")]
    public float RestraintCoolTimeSec { get; set; }

    [JsonPropertyName("stunMax_")]
    public float StunMax { get; set; }

    [JsonPropertyName("damageStunTimerStopSec_")]
    public float DamageStunTimerStopSec { get; set; }

    [JsonPropertyName("autoHealStunPerSec_")]
    public float AutoHealStunPerSec { get; set; }

    [JsonPropertyName("stunMaxIncreaseRate_")]
    public float StunMaxIncreaseRate { get; set; }

    [JsonPropertyName("stunMaxIncreaseMaxCount_")]
    public int StunMaxIncreaseMaxCount { get; set; }

    [JsonPropertyName("stunSec_")]
    public float StunSec { get; set; }

    [JsonPropertyName("stunSecIncrementRate_")]
    public float StunSecIncrementRate { get; set; }

    [JsonPropertyName("stunClearLimitRate_")]
    public float StunClearLimitRate { get; set; }

    [JsonPropertyName("stoneEnableMoveFrame_")]
    public float StoneEnableMoveFrame { get; set; }

    [JsonPropertyName("fearDeffenceDownPercent_")]
    public float FearDeffenceDownPercent { get; set; }

    [JsonPropertyName("stoneMoveMotRate_")]
    public float StoneMoveMotRate { get; set; }

    [JsonPropertyName("burn_SupHpRate_")]
    public BindingList<float> Burn_SupHpRate { get; set; }

    [JsonPropertyName("burn_DamageInterval_")]
    public float Burn_DamageInterval { get; set; }

    [JsonPropertyName("burn_EmDamageRate_")]
    public float Burn_EmDamageRate { get; set; }

    [JsonPropertyName("poison_SupHpRate_")]
    public BindingList<float> Poison_SupHpRate { get; set; }

    [JsonPropertyName("poison_DamageInterval_")]
    public float Poison_DamageInterval { get; set; }

    [JsonPropertyName("poison_EmDamageRate_")]
    public float Poison_EmDamageRate { get; set; }

    [JsonPropertyName("dimension_SupHpRate_")]
    public BindingList<float> Dimension_SupHpRate { get; set; }

    [JsonPropertyName("dimension_DamageInterval_")]
    public float Dimension_DamageInterval { get; set; }

    [JsonPropertyName("dimension_DamageLimit7st_")]
    public BindingList<float> Dimension_DamageLimit7st { get; set; }

    [JsonPropertyName("maxHpDebuffRate_")]
    public BindingList<float> MaxHpDebuffRate { get; set; }

    [JsonPropertyName("debuffTimeExtendParam_")]
    public BindingList<DebuffTimeExtendParam> DebuffTimeExtendParam { get; set; }
}


/// <summary>
/// PlayerAilmentParameter::DebuffTimeExtendParam
/// </summary>
public class DebuffTimeExtendParam
{
    [JsonPropertyName("type_")]
    public int Type { get; set; }

    [JsonPropertyName("rate_")]
    public float Rate { get; set; }
}

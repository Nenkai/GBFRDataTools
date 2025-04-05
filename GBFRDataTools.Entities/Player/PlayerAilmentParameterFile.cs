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

        PlayerAilmentParameterFile paramFile = JsonSerializer.Deserialize<PlayerAilmentParameterFile>(text, DefaultJsonSerializerOptions.InstanceForRead);
        return paramFile;
    }
}

public class PlayerAilmentParameter
{
    [JsonPropertyName("frostbiteCoolTimeSec_")]
    public float FrostbiteCoolTimeSec { get; set; } = 2.0f;

    [JsonPropertyName("restraintCoolTimeSec_")]
    public float RestraintCoolTimeSec { get; set; } = 3.0f;

    [JsonPropertyName("stunMax_")]
    public float StunMax { get; set; } = 100.0f;

    [JsonPropertyName("damageStunTimerStopSec_")]
    public float DamageStunTimerStopSec { get; set; } = 3.0f;

    [JsonPropertyName("autoHealStunPerSec_")]
    public float AutoHealStunPerSec { get; set; } = 10.0f;

    [JsonPropertyName("stunMaxIncreaseRate_")]
    public float StunMaxIncreaseRate { get; set; } = 20.0f;

    [JsonPropertyName("stunMaxIncreaseMaxCount_")]
    public int StunMaxIncreaseMaxCount { get; set; } = 3;

    [JsonPropertyName("stunSec_")]
    public float StunSec { get; set; } = 5.0f;

    [JsonPropertyName("stunSecIncrementRate_")]
    public float StunSecIncrementRate { get; set; } = 20.0f;

    [JsonPropertyName("stunClearLimitRate_")]
    public float StunClearLimitRate { get; set; } = 25.0f;

    [JsonPropertyName("stoneEnableMoveFrame_")]
    public float StoneEnableMoveFrame { get; set; } = 20.0f;

    [JsonPropertyName("fearDeffenceDownPercent_")]
    public float FearDeffenceDownPercent { get; set; } = 30.0f;

    [JsonPropertyName("stoneMoveMotRate_")]
    public float StoneMoveMotRate { get; set; } = 0.4f;

    [JsonPropertyName("burn_SupHpRate_")]
    public BindingList<float> Burn_SupHpRate { get; set; } = [];

    [JsonPropertyName("burn_DamageInterval_")]
    public float Burn_DamageInterval { get; set; } = 1.0f;

    [JsonPropertyName("burn_EmDamageRate_")]
    public float Burn_EmDamageRate { get; set; } = 1.0f;

    [JsonPropertyName("poison_SupHpRate_")]
    public BindingList<float> Poison_SupHpRate { get; set; } = [];

    [JsonPropertyName("poison_DamageInterval_")]
    public float Poison_DamageInterval { get; set; } = 1.0f;

    [JsonPropertyName("poison_EmDamageRate_")]
    public float Poison_EmDamageRate { get; set; } = 1.0f;

    [JsonPropertyName("dimension_SupHpRate_")]
    public BindingList<float> Dimension_SupHpRate { get; set; }

    [JsonPropertyName("dimension_DamageInterval_")]
    public float Dimension_DamageInterval { get; set; } = 1.0f;

    [JsonPropertyName("dimension_DamageLimit7st_")]
    public BindingList<float> Dimension_DamageLimit7st { get; set; } = [0.1f, 0.15f, 0.2f, 0.25f, 0.3f];

    [JsonPropertyName("maxHpDebuffRate_")]
    public BindingList<float> MaxHpDebuffRate { get; set; } = [0.1f, 0.15f, 0.2f, 0.25f, 0.3f];

    [JsonPropertyName("debuffTimeExtendParam_")]
    public BindingList<DebuffTimeExtendParam> DebuffTimeExtendParam { get; set; } = [];
}


/// <summary>
/// PlayerAilmentParameter::DebuffTimeExtendParam
/// </summary>
public class DebuffTimeExtendParam
{
    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("rate_")]
    public float Rate { get; set; } = 0.0f;
}

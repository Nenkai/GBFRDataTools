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

public class RescueParamFile
{
    [JsonPropertyName(nameof(RescueParam))]
    public RescueParam RescueParam { get; set; }

    public static RescueParamFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(text);

        RescueParamFile paramFile = JsonSerializer.Deserialize<RescueParamFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class RescueParam
{
    [JsonPropertyName("AutoHealAmount")]
    public float AutoHealAmount { get; set; }

    [JsonPropertyName("AutoHealAmount_inBattle")]
    public float AutoHealAmount_inBattle { get; set; }

    [JsonPropertyName("HelpHealAmount")]
    public float HelpHealAmount { get; set; }

    [JsonPropertyName("HelpHealAmount_inBattle")]
    public float HelpHealAmount_inBattle { get; set; }

    [JsonPropertyName("InputHealAmount_")]
    public float InputHealAmount { get; set; }

    [JsonPropertyName("NpcInputHealAmount_")]
    public float NpcInputHealAmount { get; set; }

    [JsonPropertyName("GageMax_NewMode")]
    public float GageMax_NewMode { get; set; }

    [JsonPropertyName("dieCountMax_")]
    public int DieCountMax { get; set; }

    [JsonPropertyName("gameOverCrisisSecMin_")]
    public float GameOverCrisisSecMin { get; set; }

    [JsonPropertyName("gameOverCrisisSecMax_")]
    public float GameOverCrisisSecMax { get; set; }

    [JsonPropertyName("npcUsePotionCountMax_")]
    public int NpcUsePotionCountMax { get; set; }

    [JsonPropertyName("npcUsePotionTriggerHpRate_")]
    public float NpcUsePotionTriggerHpRate { get; set; }

    [JsonPropertyName("npcUsePotionCoolTime_")]
    public float NpcUsePotionCoolTime { get; set; }

    [JsonPropertyName("npcUsePotionCoolTimeRandom_")]
    public float NpcUsePotionCoolTimeRandom { get; set; }

    [JsonPropertyName("npcPotionHealRate_")]
    public float NpcPotionHealRate { get; set; }

    [JsonPropertyName("npcPotionHealMax_")]
    public int NpcPotionHealMax { get; set; }

    [JsonPropertyName("npcUsePotionWaitTimeMin_")]
    public float NpcUsePotionWaitTimeMin { get; set; }

    [JsonPropertyName("npcUsePotionWaitTimeMax_")]
    public float NpcUsePotionWaitTimeMax { get; set; }

    [JsonPropertyName("dieCountMax_Ultimate_")]
    public int DieCountMax_Ultimate { get; set; }

    [JsonPropertyName("gameOverCrisisSecMin_Ultimate_")]
    public float GameOverCrisisSecMin_Ultimate { get; set; }

    [JsonPropertyName("gameOverCrisisSecMax_Ultimate_")]
    public float GameOverCrisisSecMax_Ultimate { get; set; }

    [JsonPropertyName("isUltimateDifficultyChange_")]
    public bool IsUltimateDifficultyChange { get; set; }

    [JsonPropertyName("selfInputInterval_")]
    public int SelfInputInterval { get; set; }

    [JsonPropertyName("dieCountGageDecreaseBias_2")]
    public float DieCountGageDecreaseBias_2 { get; set; }

    [JsonPropertyName("dieCountGageDecreaseBias_3")]
    public float DieCountGageDecreaseBias_3 { get; set; }

    [JsonPropertyName("dieCountGageDecreaseBias_4")]
    public float DieCountGageDecreaseBias_4 { get; set; }
}

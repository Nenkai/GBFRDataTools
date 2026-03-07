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

public class RescueParam
{
    [JsonPropertyName("AutoHealAmount")]
    public float AutoHealAmount { get; set; } = 11.0f;

    [JsonPropertyName("AutoHealAmount_inBattle")]
    public float AutoHealAmount_inBattle { get; set; } = 5.5f;

    [JsonPropertyName("HelpHealAmount")]
    public float HelpHealAmount { get; set; } = 40.0f;

    [JsonPropertyName("HelpHealAmount_inBattle")]
    public float HelpHealAmount_inBattle { get; set; } = 20.0f;

    [JsonPropertyName("InputHealAmount_")]
    public float InputHealAmount { get; set; } = 4.0f;

    [JsonPropertyName("NpcInputHealAmount_")]
    public float NpcInputHealAmount { get; set; } = 4.0f;

    [JsonPropertyName("GageMax_NewMode")]
    public float GageMax_NewMode { get; set; } = 1500.0f;

    [JsonPropertyName("dieCountMax_")]
    public int DieCountMax { get; set; } = 5;

    [JsonPropertyName("gameOverCrisisSecMin_")]
    public float GameOverCrisisSecMin { get; set; } = 10.0f;

    [JsonPropertyName("gameOverCrisisSecMax_")]
    public float GameOverCrisisSecMax { get; set; } = 30.0f;

    [JsonPropertyName("npcUsePotionCountMax_")]
    public int NpcUsePotionCountMax { get; set; } = 4;

    [JsonPropertyName("npcUsePotionTriggerHpRate_")]
    public float NpcUsePotionTriggerHpRate { get; set; } = 30.0f;

    [JsonPropertyName("npcUsePotionCoolTime_")]
    public float NpcUsePotionCoolTime { get; set; } = 20.0f;

    [JsonPropertyName("npcUsePotionCoolTimeRandom_")]
    public float NpcUsePotionCoolTimeRandom { get; set; } = 20.0f;

    [JsonPropertyName("npcPotionHealRate_")]
    public float NpcPotionHealRate { get; set; } = 30.0f;

    [JsonPropertyName("npcPotionHealMax_")]
    public int NpcPotionHealMax { get; set; } = 9999;

    [JsonPropertyName("npcUsePotionWaitTimeMin_")]
    public float NpcUsePotionWaitTimeMin { get; set; } = 1.5f;

    [JsonPropertyName("npcUsePotionWaitTimeMax_")]
    public float NpcUsePotionWaitTimeMax { get; set; } = 5.0f;

    [JsonPropertyName("dieCountMax_Ultimate_")]
    public int DieCountMax_Ultimate { get; set; } = 5;

    [JsonPropertyName("gameOverCrisisSecMin_Ultimate_")]
    public float GameOverCrisisSecMin_Ultimate { get; set; } = 10.0f;

    [JsonPropertyName("gameOverCrisisSecMax_Ultimate_")]
    public float GameOverCrisisSecMax_Ultimate { get; set; } = 30.0f;

    [JsonPropertyName("isUltimateDifficultyChange_")]
    public bool IsUltimateDifficultyChange { get; set; } = false;

    [JsonPropertyName("selfInputInterval_")]
    public int SelfInputInterval { get; set; } = 10;

    [JsonPropertyName("dieCountGageDecreaseBias_2")]
    public float DieCountGageDecreaseBias_2 { get; set; } = 1.0f;

    [JsonPropertyName("dieCountGageDecreaseBias_3")]
    public float DieCountGageDecreaseBias_3 { get; set; } = 1.0f;

    [JsonPropertyName("dieCountGageDecreaseBias_4")]
    public float DieCountGageDecreaseBias_4 { get; set; } = 1.0f;
}

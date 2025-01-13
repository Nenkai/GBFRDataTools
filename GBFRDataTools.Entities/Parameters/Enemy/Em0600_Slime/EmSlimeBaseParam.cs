using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0600_Slime;

public class EmSlimeBaseParam : EnemyParameterInfo
{
    [JsonPropertyName("escapeDamageStackMax_")]
    public float EscapeDamageStackMax { get; set; }

    [JsonPropertyName("hitStopTimeScale_")]
    public float HitStopTimeScale { get; set; }

    [JsonPropertyName("specialArtsDamageScale_")]
    public float SpecialArtsDamageScale { get; set; }

    [JsonPropertyName("linkAttackDamageScale_")]
    public float LinkAttackDamageScale { get; set; }

    [JsonPropertyName("dropMoneyHpRate_")]
    public float DropMoneyHpRate { get; set; }

    [JsonPropertyName("dropMoney_")]
    public int DropMoney { get; set; }

    [JsonPropertyName("canGetMoneyHpRate_")]
    public BindingList<int> CanGetMoneyHpRate { get; set; } = []; // std::vector<int>

    [JsonPropertyName("canGetMoneyRate_")]
    public BindingList<int> CanGetMoneyRate { get; set; } = []; // std::vector<int>

    [JsonPropertyName("canGetMoneyMaxValue_")]
    public int CanGetMoneyMaxValue { get; set; }

    [JsonPropertyName("linkAttackDamageDropMoneyVal_")]
    public int LinkAttackDamageDropMoneyVal { get; set; }

    [JsonPropertyName("linkFinishDamageDropMoneyVal_")]
    public int LinkFinishDamageDropMoneyVal { get; set; }

    [JsonPropertyName("damageCutPercent_")]
    public float DamageCutPercent { get; set; }

    [JsonPropertyName("runBoundMax_")]
    public int RunBoundMax { get; set; }

    [JsonPropertyName("runMoveAngle_")]
    public float RunMoveAngle { get; set; }

    [JsonPropertyName("runMoveTime_")]
    public float RunMoveTime { get; set; }

    [JsonPropertyName("runLastMoveTime_")]
    public float RunLastMoveTime { get; set; }

    [JsonPropertyName("escapeTimeSecMax_")]
    public float EscapeTimeSecMax { get; set; }

    [JsonPropertyName("escapeTimeSecMin_")]
    public float EscapeTimeSecMin { get; set; }

    [JsonPropertyName("escapeTimeSecDecreaseNum_")]
    public int EscapeTimeSecDecreaseNum { get; set; }

    public EmSlimeBaseParam()
    {
    }
}

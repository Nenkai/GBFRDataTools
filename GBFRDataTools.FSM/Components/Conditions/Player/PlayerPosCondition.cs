using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class PlayerPosCondition : ConditionComponent
{
    [JsonPropertyName("pos_")]
    public cVec4 Pos { get; set; }

    [JsonPropertyName("radius_")]
    public float Radius { get; set; }

    [JsonPropertyName("height_")]
    public float Height { get; set; }

    [JsonPropertyName("playerCount_")]
    public int PlayerCount { get; set; }

    [JsonPropertyName("isCheckOnlyXZ_")]
    public bool IsCheckOnlyXZ { get; set; }

    [JsonPropertyName("isOffset_")]
    public bool IsOffset { get; set; }

    [JsonPropertyName("isManualPlayer_")]
    public bool IsManualPlayer { get; set; }
}

using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotAttackIgnoreScaleAction : ShotAttackAction
{
    [JsonPropertyName("isIgnoreScaleX_")]
    public bool IsIgnoreScaleX { get; set; } = true;

    [JsonPropertyName("isIgnoreScaleY_")]
    public bool IsIgnoreScaleY { get; set; } = true;

    [JsonPropertyName("isIgnoreScaleZ_")]
    public bool IsIgnoreScaleZ { get; set; } = true;
}
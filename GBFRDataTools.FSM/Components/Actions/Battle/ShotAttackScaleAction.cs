using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotAttackScaleAction : ShotAttackAction
{
    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; }

    [JsonPropertyName("scaleSize_")]
    public cVec4 ScaleSize { get; set; }
}

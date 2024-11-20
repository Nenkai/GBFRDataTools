using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotAttackScaleAction : ShotAttackAction
{
    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; }

    [JsonPropertyName("scaleSize_")]
    public cVec4 ScaleSize { get; set; }
}

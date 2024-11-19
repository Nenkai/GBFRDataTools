using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDamageJumpAction : ActionComponent
{
    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; }

    [JsonPropertyName("jumpSpeedYCountDecay_")]
    public float JumpSpeedYCountDecay { get; set; }

    [JsonPropertyName("comboMaxCount_")]
    public int ComboMaxCount { get; set; }
}

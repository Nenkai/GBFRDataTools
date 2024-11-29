using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalanceSetMixBalanceAction : ActionComponent
{
    [JsonPropertyName("presetNo_")]
    public int PresetNo { get; set; } = 0;

    [JsonPropertyName("isClear_")]
    public bool IsClear { get; set; } = true;

    [JsonPropertyName("isRestore_")]
    public bool IsRestore { get; set; } = true;
}

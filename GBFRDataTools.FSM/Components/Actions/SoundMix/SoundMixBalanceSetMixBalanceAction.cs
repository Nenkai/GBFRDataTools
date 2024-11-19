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
    public int PresetNo { get; set; }

    [JsonPropertyName("isClear_")]
    public bool IsClear { get; set; }

    [JsonPropertyName("isRestore_")]
    public bool IsRestore { get; set; }
}

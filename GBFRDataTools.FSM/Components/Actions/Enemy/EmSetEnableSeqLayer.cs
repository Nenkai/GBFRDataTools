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

public class EmSetEnableSeqLayer : ActionComponent
{
    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("layerIndex_")]
    public int LayerIndex { get; set; } = 0;

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = false;
}

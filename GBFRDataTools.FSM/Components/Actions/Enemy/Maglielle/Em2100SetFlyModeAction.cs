using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Maglielle;

public class Em2100SetFlyModeAction : ActionComponent
{
    [JsonPropertyName("setModeType_")]
    public int SetModeType { get; set; }

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; }
}
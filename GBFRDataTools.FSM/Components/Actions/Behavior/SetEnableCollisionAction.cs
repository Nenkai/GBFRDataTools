using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class SetEnableCollisionAction : ActionComponent
{
    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = true;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;
}

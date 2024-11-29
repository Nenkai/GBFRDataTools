using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NpcShopWaitAction : ActionComponent
{
    [JsonPropertyName("waitMotionName_")]
    public string WaitMotionName { get; set; } = "e000";

    [JsonPropertyName("gesturesMotion_")]
    public BindingList<string> GesturesMotion { get; set; } = [];

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 10.0f;
}

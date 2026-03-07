using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NpcShopWaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NpcShopWaitAction);

    [JsonPropertyName("waitMotionName_")]
    public string WaitMotionName { get; set; } = "e000";

    [JsonPropertyName("gesturesMotion_")]
    public BindingList<string> GesturesMotion { get; set; } = []; // std::vector<string>

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 10.0f;
}

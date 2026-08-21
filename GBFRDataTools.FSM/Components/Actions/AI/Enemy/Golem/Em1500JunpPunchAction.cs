using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500JunpPunchAction : Em1500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500JunpPunchAction);

    [JsonPropertyName("hardModeExActionLoopNum_")]
    public int HardModeExActionLoopNum { get; set; } = 0; 
}
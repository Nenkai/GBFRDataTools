using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Tayuitar;

public class Em1900SpecialBreakAction : ActionComponent
{
    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 14.5f;
}

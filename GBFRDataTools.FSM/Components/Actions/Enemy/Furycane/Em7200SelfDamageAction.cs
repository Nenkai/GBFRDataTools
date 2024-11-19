using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Furycane;

public class Em7200SelfDamageAction : ActionComponent
{
    [JsonPropertyName("delayTime_")]
    public float DelayTime { get; set; }

    [JsonPropertyName("eventAttackRate_")]
    public float EventAttackRate { get; set; }
}

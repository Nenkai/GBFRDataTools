using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300DoppelSonicRushAction : ActionComponent
{
    [JsonPropertyName("startWaitTime_")]
    public float StartWaitTime { get; set; } = 4.15f;

    [JsonPropertyName("slashInterval_")]
    public float SlashInterval { get; set; } = 0.8f;

}

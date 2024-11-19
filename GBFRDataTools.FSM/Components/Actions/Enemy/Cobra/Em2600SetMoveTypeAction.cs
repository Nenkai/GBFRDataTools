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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Cobra;

public class Em2600SetMoveTypeAction : ShotAttackAction
{
    [JsonPropertyName("setMoveType_")]
    public int SetMoveType { get; set; }

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; }
}

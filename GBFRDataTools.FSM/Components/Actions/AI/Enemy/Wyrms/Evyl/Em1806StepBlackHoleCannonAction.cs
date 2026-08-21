using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806StepBlackHoleCannonAction : Em1800StepFireBallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806StepBlackHoleCannonAction);

    [JsonPropertyName("moveRate_")]
    public Vector4 MoveRate { get; set; } = Vector4.One; 

    [JsonPropertyName("nextCycleId_")]
    public int NextCycleId { get; set; } = 1; 
}
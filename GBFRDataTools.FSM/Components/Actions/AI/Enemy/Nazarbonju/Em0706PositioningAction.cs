using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706PositioningAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706PositioningAction);

    [JsonPropertyName("homingAngleFront_")]
    public float HomingAngleFront { get; set; } = 8f; 

    [JsonPropertyName("homingAngleLR_")]
    public float HomingAngleLR { get; set; } = 5f; 

    [JsonPropertyName("homingAngleBack_")]
    public float HomingAngleBack { get; set; } = 3f; 

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1f; 

    [JsonPropertyName("isBattleAreaCenterMove_")]
    public bool IsBattleAreaCenterMove { get; set; } = false; 
}
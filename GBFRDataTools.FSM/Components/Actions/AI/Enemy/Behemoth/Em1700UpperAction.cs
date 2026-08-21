using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700UpperAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700UpperAction);

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0; 

    [JsonPropertyName("landTargetLength_")]
    public float LandTargetLength { get; set; } = 0f; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.5f; 

    [JsonPropertyName("isSkipEndMotion_")]
    public bool IsSkipEndMotion { get; set; } = false;
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2104HomingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2104HomingAction);

    [JsonPropertyName("homingType_")]
    public int HomingType { get; set; } = 0; 

    [JsonPropertyName("attackIntervalSec_")]
    public float AttackIntervalSec { get; set; } = 0.35f; 

    [JsonPropertyName("isSpArts_")]
    public bool IsSpArts { get; set; } = false; 

    [JsonPropertyName("waitOverheadSec_")]
    public float WaitOverheadSec { get; set; } = 1.5f; 

    [JsonPropertyName("attackSpeed_")]
    public float AttackSpeed { get; set; } = 32f; 
}


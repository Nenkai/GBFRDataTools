using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class SuperiorWeaponFollowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SuperiorWeaponFollowAction);

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 2f; 

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 5f; 

    [JsonPropertyName("followTargetType_")]
    public int FollowTargetType { get; set; } = 0; 

    [JsonPropertyName("followDistType_")]
    public int FollowDistType { get; set; } = 0; 
}

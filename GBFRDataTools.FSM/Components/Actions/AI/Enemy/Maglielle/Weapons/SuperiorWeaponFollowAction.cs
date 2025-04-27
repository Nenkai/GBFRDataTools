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
    public float MoveSpeed { get; set; } = 2f; // Offset 0x44

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 5f; // Offset 0x48

    [JsonPropertyName("followTargetType_")]
    public int FollowTargetType { get; set; } = 0; // Offset 0x4C

    [JsonPropertyName("followDistType_")]
    public int FollowDistType { get; set; } = 0; // Offset 0x50

    public SuperiorWeaponFollowAction()
    {
    }
}

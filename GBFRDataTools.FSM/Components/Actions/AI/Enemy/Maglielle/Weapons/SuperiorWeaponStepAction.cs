using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class SuperiorWeaponStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SuperiorWeaponStepAction);

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 1f; // Offset 0x50

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 5f; // Offset 0x54

    [JsonPropertyName("step_")]
    public int Step { get; set; } = 0; // Offset 0x58

    [JsonPropertyName("isPlayAnim_")]
    public bool IsPlayAnim { get; set; } = true; // Offset 0x5C

    public SuperiorWeaponStepAction()
    {
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class SuperiorWeaponRecoveryAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SuperiorWeaponRecoveryAction);

    [JsonPropertyName("weaponType_")]
    public int WeaponType { get; set; } = 0; // Offset 0x64

    public SuperiorWeaponRecoveryAction()
    {
    }
}

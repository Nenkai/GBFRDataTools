using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004ShieldLaunchAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004ShieldLaunchAttackAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 6f; // Offset 0x34

    [JsonPropertyName("ajustDistanceBase_")]
    public float AjustDistanceBase { get; set; } = 1.5f; // Offset 0x38

    [JsonPropertyName("ajustDistanceMax_")]
    public float AjustDistanceMax { get; set; } = 3f; // Offset 0x3C

    public Em0004ShieldLaunchAttackAction()
    {
    }
}

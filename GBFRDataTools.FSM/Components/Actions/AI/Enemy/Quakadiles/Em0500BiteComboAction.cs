using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500BiteComboAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500BiteComboAction);

    [JsonPropertyName("moveRateEm0501Armor_")]
    public float MoveRateEm0501Armor { get; set; } = 1.5f; // Offset 0x78

    [JsonPropertyName("homingAngle1_")]
    public float HomingAngle1 { get; set; } = 5f; // Offset 0x64

    [JsonPropertyName("homingAngleWakeUp_")]
    public float HomingAngleWakeUp { get; set; } = 1f; // Offset 0x68

    [JsonPropertyName("homingAngle2_")]
    public float HomingAngle2 { get; set; } = 2f; // Offset 0x6C

    [JsonPropertyName("homingAngle3_")]
    public float HomingAngle3 { get; set; } = 2f; // Offset 0x70

    [JsonPropertyName("endBite_")]
    public bool EndBite { get; set; } = false; // Offset 0x74

    [JsonPropertyName("chargeBite_")]
    public bool ChargeBite { get; set; } = true; // Offset 0x75

    public Em0500BiteComboAction()
    {
    }
}



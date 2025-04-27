using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OminousForm;

public class Em2800ComboAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2800ComboAttackAction);

    [JsonPropertyName("comboDist_")]
    public float ComboDist { get; set; } = 10f; // Offset 0x34

    [JsonPropertyName("comboProbability_")]
    public int ComboProbability { get; set; } = 100; // Offset 0x38

    [JsonPropertyName("comboAngleDeg_")]
    public float ComboAngleDeg { get; set; } = 190f; // Offset 0x3C

    public Em2800ComboAttackAction()
    {
    }
}

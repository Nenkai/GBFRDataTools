using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0701DiamondDustAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0701DiamondDustAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x30

    [JsonPropertyName("isCounterAttack_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public bool IsCounterAttack { get; set; }

    public Em0701DiamondDustAction()
    {
    }
}

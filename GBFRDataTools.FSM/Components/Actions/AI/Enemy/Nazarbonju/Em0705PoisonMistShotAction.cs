using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0705PoisonMistShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0705PoisonMistShotAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x30

    public Em0705PoisonMistShotAction()
    {
    }
}

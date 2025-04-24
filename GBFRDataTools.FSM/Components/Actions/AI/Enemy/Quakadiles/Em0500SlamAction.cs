using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500SlamAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500SlamAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 2f; // Offset 0x30

    public Em0500SlamAction()
    {
    }
}
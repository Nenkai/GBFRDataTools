using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200DoubleFangAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200DoubleFangAttackAction);

    [JsonPropertyName("firstHomingAngle_")]
    public float FirstHomingAngle { get; set; } = 0.02f; // Offset 0x30

    [JsonPropertyName("secondHomingAngle_")]
    public float SecondHomingAngle { get; set; } = 0.02f; // Offset 0x34

    public Em0200DoubleFangAttackAction()
    {
    }
}

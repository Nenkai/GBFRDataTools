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

public class Em0200FangAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200FangAttackAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.02f; // Offset 0x30

    public Em0200FangAttackAction()
    {
    }
}

using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100MeleeSwordThrowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100MeleeSwordThrowAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 45f; // Offset 0x50

    public Em2100MeleeSwordThrowAction()
    {
    }
}
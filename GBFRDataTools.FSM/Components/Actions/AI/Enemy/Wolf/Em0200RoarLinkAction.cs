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

public class Em0200RoarLinkAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200RoarLinkAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.2f; // Offset 0x30

    public Em0200RoarLinkAction()
    {
    }
}

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

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805TriBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805TriBeamAction);

    [JsonPropertyName("moveHoming_")]
    public bool MoveHoming { get; set; } = false; // Offset 0x70

    public Em1805TriBeamAction()
    {
    }
}



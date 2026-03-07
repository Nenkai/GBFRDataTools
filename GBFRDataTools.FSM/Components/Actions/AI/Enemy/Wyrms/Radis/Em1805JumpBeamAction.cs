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

public class Em1805JumpBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805JumpBeamAction);

    [JsonPropertyName("beamRate_")]
    public float BeamRate { get; set; } = 1.5f; // Offset 0x40

    public Em1805JumpBeamAction()
    {
    }
}



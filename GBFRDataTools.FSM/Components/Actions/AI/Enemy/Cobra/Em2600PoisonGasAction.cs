using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600PoisonGasAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600PoisonGasAction);

    [JsonPropertyName("shotGasNum_")]
    public int ShotGasNum { get; set; } = 4; // Offset 0x40

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x50

    public Em2600PoisonGasAction()
    {
    }
}


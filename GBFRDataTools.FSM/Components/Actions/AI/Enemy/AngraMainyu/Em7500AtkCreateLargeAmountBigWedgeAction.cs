using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500AtkCreateLargeAmountBigWedgeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AtkCreateLargeAmountBigWedgeAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 5f; // Offset 0x40

    public Em7500AtkCreateLargeAmountBigWedgeAction()
    {
    }
}


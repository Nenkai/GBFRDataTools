using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1002DropArrowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1002DropArrowAction);

    [JsonPropertyName("readyTime_")]
    public float ReadyTime { get; set; } = 5f; // Offset 0x40

    [JsonPropertyName("signStartTime_")]
    public float SignStartTime { get; set; } = 2f; // Offset 0x44

    [JsonPropertyName("maxAddRandomTime_")]
    public float MaxAddRandomTime { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("maxFirstWaitRandomTime_")]
    public float MaxFirstWaitRandomTime { get; set; } = 10f; // Offset 0x50

    public Em1002DropArrowAction()
    {
    }
}
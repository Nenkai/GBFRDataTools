using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class Em1100WalkAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1100WalkAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 2f; // Offset 0x40

    [JsonPropertyName("loopSec_")]
    public float LoopSec { get; set; } = 1f; // Offset 0x44

    [JsonPropertyName("walkDirType_")]
    public int WalkDirType { get; set; } = 0; // Offset 0x48

    public Em1100WalkAction()
    {
    }
}

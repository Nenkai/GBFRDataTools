using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.VulkanBolla;

public class Em7100MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100MoveAction);

    [JsonPropertyName("moveSpeedMaxScale_")]
    public float MoveSpeedMaxScale { get; set; } = 1f; // Offset 0x98

    [JsonPropertyName("rotDegSpeedScale_")]
    public float RotDegSpeedScale { get; set; } = 1f; // Offset 0x9C

    [JsonPropertyName("speedChangeSecScale_")]
    public float SpeedChangeSecScale { get; set; } = 1f; // Offset 0xA0

    public Em7100MoveAction()
    {
    }
}

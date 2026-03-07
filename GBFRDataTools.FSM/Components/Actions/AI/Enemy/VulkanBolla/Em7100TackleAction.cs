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

public class Em7100TackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100TackleAction);

    [JsonPropertyName("motionEndSec_")]
    public float MotionEndSec { get; set; } = 0f; // Offset 0x30

    [JsonPropertyName("motionInterSec_")]
    public float MotionInterSec { get; set; } = -1f; // Offset 0x34

    [JsonPropertyName("turnRotY_")]
    public float TurnRotY { get; set; } = 0f; // Offset 0x38

    public Em7100TackleAction()
    {
    }
}

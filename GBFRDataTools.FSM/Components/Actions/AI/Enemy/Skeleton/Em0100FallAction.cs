using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100FallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100FallAction);

    [JsonPropertyName("motionIdNameFallLoop_")]
    public string MotionIdNameFallLoop { get; set; } // Offset 0x38

    [JsonPropertyName("motionIdNameLanding_")]
    public string MotionIdNameLanding { get; set; } // Offset 0x40

    public Em0100FallAction()
    {
    }
}

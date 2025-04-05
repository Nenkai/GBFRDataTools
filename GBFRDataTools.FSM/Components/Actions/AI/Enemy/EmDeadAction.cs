using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDeadAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDeadAction);

    [JsonPropertyName("motionIdNameDead_")]
    public /* sys::String */ string MotionIdNameDead { get; set; } = "0550";

    [JsonPropertyName("isDeadExplode")]
    public bool IsDeadExplode { get; set; } = true;

    [JsonPropertyName("IsInterpMotion_")]
    public bool IsInterpMotion { get; set; } = true;
}

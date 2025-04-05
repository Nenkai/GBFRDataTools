using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.VulkanBolla;

public class Em7100FireBallAction : EmDamageMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100FireBallAction);

    [JsonPropertyName("repeatCount_")]
    public int RepeatCount { get; set; } = 0;

    [JsonPropertyName("startSec_")]
    public float StartSec { get; set; } = 0.0f;
}

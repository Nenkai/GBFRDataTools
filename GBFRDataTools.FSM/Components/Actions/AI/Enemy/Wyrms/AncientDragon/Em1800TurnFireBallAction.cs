using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800TurnFireBallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800TurnFireBallAction);

    [JsonPropertyName("blendMotionRateSpeed_")]
    public float BlendMotionRateSpeed { get; set; } = 0.1f; // Offset 0x5C

    public Em1800TurnFireBallAction()
    {
    }
}

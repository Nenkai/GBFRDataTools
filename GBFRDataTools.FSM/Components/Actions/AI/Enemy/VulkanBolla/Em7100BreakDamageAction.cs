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

public class Em7100BreakDamageAction : EmDamageMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100BreakDamageAction);

    [JsonPropertyName("loopAnimId_")]
    public string LoopAnimId { get; set; } = string.Empty;

    [JsonPropertyName("endAnimId_")]
    public string EndAnimId { get; set; } = string.Empty;

    public Em7100BreakDamageAction()
    {
        InterTime = -1f;
        AnimMoveRateXZ = 1f;
        AnimMoveRateY = 1f;
        AnimSpeedRate = 0f;
        AnimSpeedStep = 0;
        GravityRate = 0f;
        GravityRateStep = 0;
    }
}

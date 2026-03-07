using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

public class AIEm7001ShakeGroundAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIEm7001ShakeGroundAction);

    [Obsolete("Not used by the game")]
    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; }
}

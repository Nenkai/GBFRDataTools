using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIBattleJumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleJumpAction);

    [JsonPropertyName("jumpButtonHoldSec_")]
    public float JumpButtonHoldSec { get; set; } = 0.5f;

}

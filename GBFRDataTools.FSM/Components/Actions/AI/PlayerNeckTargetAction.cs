using GBFRDataTools.FSM.Components.Actions.NavMesh;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class PlayerNeckTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerNeckTargetAction);

    [JsonPropertyName("target_")]
    public /* cVec4 */ Vector4 Target { get; set; } = Vector4.UnitW;
}

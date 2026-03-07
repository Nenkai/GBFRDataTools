using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class EmBitBaseSetTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBitBaseSetTargetAction);

    [JsonPropertyName("targetPos_")]
    public Vector4 TargetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x30

    public EmBitBaseSetTargetAction()
    {
    }
}

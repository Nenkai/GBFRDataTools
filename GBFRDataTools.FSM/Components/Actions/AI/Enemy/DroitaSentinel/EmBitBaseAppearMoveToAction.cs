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

public class EmBitBaseAppearMoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBitBaseAppearMoveToAction);

    [JsonPropertyName("movePos_")]
    public Vector4 MovePos { get; set; } = Vector4.UnitW; 
}

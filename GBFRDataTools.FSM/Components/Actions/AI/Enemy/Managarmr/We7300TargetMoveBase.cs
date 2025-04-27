using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class We7300TargetMoveBase : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300TargetMoveBase);

    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("eraseTargetOffset_")]
    public bool EraseTargetOffset { get; set; } = false; // Offset 0x44

    [JsonPropertyName("callSe_")]
    public bool CallSe { get; set; } = true; // Offset 0x45

    public We7300TargetMoveBase()
    {
    }
}

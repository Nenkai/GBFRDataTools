using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr.Weapons;

public class We7300TargetMoveAction : We7300TargetMoveBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300TargetMoveAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 2f; // Offset 0x70

    [JsonPropertyName("rotType_")]
    public int RotType { get; set; } = 0; // Offset 0x74

    [JsonPropertyName("createGroundEffect_")]
    public bool CreateGroundEffect { get; set; } = false; // Offset 0x78

    public We7300TargetMoveAction()
    {
    }
}

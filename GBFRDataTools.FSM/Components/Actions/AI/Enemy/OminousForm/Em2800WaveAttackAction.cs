using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OminousForm;

public class Em2800WarpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2800WarpAction);

    [JsonPropertyName("warpLength_")]
    public float WarpLength { get; set; } = 5f; // Offset 0x38

    [JsonPropertyName("isWarpAttack_")]
    public bool IsWarpAttack { get; set; } = false; // Offset 0x34

    public Em2800WarpAction()
    {
    }
}

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806StepBlackHoleCannonAction : Em1800StepFireBallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806StepBlackHoleCannonAction);

    [JsonPropertyName("moveRate_")]
    public Vector4 MoveRate { get; set; } = new Vector4(1f, 1f, 1f, 1f); // Offset 0x70

    [JsonPropertyName("nextCycleId_")]
    public int NextCycleId { get; set; } = 1; // Offset 0x80

    public Em1806StepBlackHoleCannonAction()
    {
    }
}
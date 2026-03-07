using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706FallIcePillarAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706FallIcePillarAction);

    [JsonPropertyName("isOdAbilityBefore_")]
    public bool IsOdAbilityBefore { get; set; } = false; // Offset 0x98

    public Em0706FallIcePillarAction()
    {
    }
}
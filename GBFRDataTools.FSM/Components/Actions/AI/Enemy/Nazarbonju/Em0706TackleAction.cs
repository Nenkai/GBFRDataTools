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

public class Em0706TackleAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706TackleAction);

    [JsonPropertyName("tackleMoveRate_")]
    public float TackleMoveRate { get; set; } = 1f; // Offset 0x80

    [JsonPropertyName("isCallIceShotMove_")]
    public bool IsCallIceShotMove { get; set; } = false; // Offset 0x84

    public Em0706TackleAction()
    {
    }
}
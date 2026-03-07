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

public class Em0706SetStartGroundPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706SetStartGroundPosAction);

    [JsonPropertyName("beginHeight_")]
    public float BeginHeight { get; set; } = 1f; // Offset 0x30

    [JsonPropertyName("endHeight_")]
    public float EndHeight { get; set; } = -10f; // Offset 0x34

    public Em0706SetStartGroundPosAction()
    {
    }
}
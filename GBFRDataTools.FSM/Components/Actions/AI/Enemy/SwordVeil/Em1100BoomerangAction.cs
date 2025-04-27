using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class Em1100BoomerangAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1100BoomerangAction);

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 8f; // Offset 0x64

    public Em1100BoomerangAction()
    {
    }
}
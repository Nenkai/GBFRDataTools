using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600MoveToAction);

    [JsonPropertyName("frontRunEndDistance_")]
    public float FrontRunEndDistance { get; set; } = 9f; // Offset 0x50

    [JsonPropertyName("frontFlyEndDistance_")]
    public float FrontFlyEndDistance { get; set; } = 14f; // Offset 0x54

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.2f; // Offset 0x58

    public Em1600MoveToAction()
    {
    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100ExForwardAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100ExForwardAttackAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 4f;

    [JsonPropertyName("isCancelAction_")]
    public bool IsCancelAction { get; set; } = false;

    [JsonPropertyName("moveEndRate_")]
    public float MoveEndRate { get; set; } = 1f;
}
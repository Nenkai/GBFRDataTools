using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyvern;

public class Em0400AttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0400AttackAction);

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0; // Offset 0x48

    [JsonPropertyName("isSetForceMiddleAction_")]
    public bool IsSetForceMiddleAction { get; set; } = false; // Offset 0x68

    [JsonPropertyName("isNotMove_")]
    public bool IsNotMove { get; set; } = false; // Offset 0x69

    public Em0400AttackAction()
    {
    }
}

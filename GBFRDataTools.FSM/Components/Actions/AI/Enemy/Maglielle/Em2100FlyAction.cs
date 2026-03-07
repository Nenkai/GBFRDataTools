using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100FlyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100FlyAction);

    [JsonPropertyName("wearSwordAttackType_")]
    public int WearSwordAttackType { get; set; } = 0; // Offset 0x98

    public Em2100FlyAction()
    {
    }
}
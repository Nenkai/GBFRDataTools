using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1003BuffAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1003BuffAction);

    [JsonPropertyName("buffType_")]
    public int BuffType { get; set; } = 0; // Offset 0x30

    public Em1003BuffAction()
    {
    }
}
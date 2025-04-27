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

public class Em2100DountAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100DountAction);

    [JsonPropertyName("donutFireSec_")]
    public float DonutFireSec { get; set; } = 3f; // Offset 0x5C

    public Em2100DountAction()
    {
    }
}
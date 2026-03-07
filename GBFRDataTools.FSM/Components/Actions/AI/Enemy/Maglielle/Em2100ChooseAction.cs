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

public class Em2100ChooseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100ChooseAction);

    [JsonPropertyName("actionIndex_")]
    public int ActionIndex { get; set; } = 0; // Offset 0x30

    public Em2100ChooseAction()
    {
    }
}
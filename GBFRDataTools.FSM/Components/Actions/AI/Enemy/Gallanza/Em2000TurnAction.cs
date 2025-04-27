using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000TurnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000TurnAction);

    [JsonPropertyName("interpFrame_")]
    public int InterpFrame { get; set; } = 24; // Offset 0x30

    public Em2000TurnAction()
    {
    }
}

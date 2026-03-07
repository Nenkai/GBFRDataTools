using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lilith;

public class Em2400SetActionNoAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400SetActionNoAction);

    [JsonPropertyName("actionNo_")]
    public int ActionNo { get; set; } = 0; // Offset 0x30

    public Em2400SetActionNoAction()
    {
    }
}

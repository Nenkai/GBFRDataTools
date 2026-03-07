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

public class Em2400MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400MoveAction);

    [JsonPropertyName("dirType_")]
    public int DirType { get; set; } = 0; // Offset 0x3C

    public Em2400MoveAction()
    {
    }
}

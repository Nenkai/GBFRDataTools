using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300DoubleSlashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DoubleSlashAction);

    [JsonPropertyName("firstHomingAngle_")]
    public float FirstHomingAngle { get; set; } = 5f; // Offset 0x34

    [JsonPropertyName("secondHomingAngle_")]
    public float SecondHomingAngle { get; set; } = 5f; // Offset 0x38

    public Em7300DoubleSlashAction()
    {
    }
}

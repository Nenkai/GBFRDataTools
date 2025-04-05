using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300PointJumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300PointJumpAction);

    [JsonPropertyName("toDoppel_")]
    public bool ToDoppel { get; set; } = false;

    [JsonPropertyName("isDoppel_")]
    public bool IsDoppel { get; set; } = false;
}

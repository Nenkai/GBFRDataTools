using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300CleaveLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300CleaveLaserAction);

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 3.0f;

    [JsonPropertyName("targetStageCenter_")]
    public bool TargetStageCenter { get; set; } = true;

    [JsonPropertyName("isOdArts")]
    public bool IsOdArts { get; set; } = false;

    [JsonPropertyName("isDoppel_")]
    public bool IsDoppel { get; set; } = false;
}

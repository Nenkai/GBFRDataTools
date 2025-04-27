using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520VanishCharacterAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520VanishCharacterAction);

    [JsonPropertyName("startRadius_")]
    public float StartRadius { get; set; } = 6f; // Offset 0x110

    [JsonPropertyName("startOffsetY_")]
    public float StartOffsetY { get; set; } = 1f; // Offset 0x114

    [JsonPropertyName("targetYMoveTime_")]
    public float TargetYMoveTime { get; set; } = 3f; // Offset 0x130

    public Em7520VanishCharacterAction()
    {
    }
}
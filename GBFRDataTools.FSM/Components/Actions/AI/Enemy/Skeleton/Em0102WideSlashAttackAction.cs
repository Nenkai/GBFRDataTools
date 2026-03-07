using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0102WideSlashAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0102WideSlashAttackAction);

    [JsonPropertyName("slashDir_")]
    public int SlashDir { get; set; } = 0;

    [JsonPropertyName("motionStartFrame_")]
    public int MotionStartFrame { get; set; } = 0;

    [JsonPropertyName("motionEndFrame_")]
    public int MotionEndFrame { get; set; } = 0;

    [JsonPropertyName("motionInterpFrame_")]
    public int MotionInterpFrame { get; set; } = 0;
}

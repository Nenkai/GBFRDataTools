using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Skeleton;

public class Em0102WideSlashAttackAction : ActionComponent
{
    [JsonPropertyName("slashDir_")]
    public int SlashDir { get; set; }

    [JsonPropertyName("motionStartFrame_")]
    public int MotionStartFrame { get; set; }

    [JsonPropertyName("motionEndFrame_")]
    public int MotionEndFrame { get; set; }

    [JsonPropertyName("motionInterpFrame_")]
    public int MotionInterpFrame { get; set; }
}

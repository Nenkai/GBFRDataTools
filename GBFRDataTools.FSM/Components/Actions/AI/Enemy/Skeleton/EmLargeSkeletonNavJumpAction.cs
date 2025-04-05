using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Skeleton;

public class EmLargeSkeletonNavJumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmLargeSkeletonNavJumpAction);

    [JsonPropertyName("jumpRot_")]
    public float JumpRot { get; set; } = 60.0f;

    [JsonPropertyName("jumpSpeed_")]
    public float JumpSpeed { get; set; } = 0.6f;
}

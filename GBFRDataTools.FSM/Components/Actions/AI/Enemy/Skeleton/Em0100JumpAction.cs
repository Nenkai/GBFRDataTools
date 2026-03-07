using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100JumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100JumpAction);

    [JsonPropertyName("jumpRot_")]
    [Obsolete("Game does not appear to read this")]
    [Description("Game does not appear to read this")]
    public float JumpRot { get; set; }

    [JsonPropertyName("jumpSpeed_")]
    [Obsolete("Game does not appear to read this")]
    [Description("Game does not appear to read this")]
    public float JumpSpeed { get; set; }

    [JsonPropertyName("motionIdNameJump_")]
    [Obsolete("Game does not appear to read this")]
    [Description("Game does not appear to read this")]
    public string MotionIdNameJump { get; set; }

    [JsonPropertyName("motionIdNameFallLoop_")]
    [Obsolete("Game does not appear to read this")]
    [Description("Game does not appear to read this")]
    public string MotionIdNameFallLoop { get; set; }

    [JsonPropertyName("motionIdNameLanding_")]
    [Obsolete("Game does not appear to read this")]
    [Description("Game does not appear to read this")]
    public string MotionIdNameLanding { get; set; }

    public Em0100JumpAction()
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NpcTurnToManualPlayerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NpcTurnToManualPlayerAction);

    [JsonPropertyName("rightMotionId_")]
    public /* sys::String*/ string RightMotionId { get; set; } = "e320";

    [JsonPropertyName("leftMotionId_")]
    public /* sys::String*/ string LeftMotionId { get; set; } = "e420";

    [JsonPropertyName("rightBackMotionId_")]
    public /* sys::String*/ string RightBackMotionId { get; set; } = "e360";

    [JsonPropertyName("leftBackMotionId_")]
    public /* sys::String*/ string LeftBackMotionId { get; set; } = "e460";

    [JsonPropertyName("endMotionId_")]
    public /* sys::String*/ string EndMotionId { get; set; } = "";
}

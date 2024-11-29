using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001MotionPlayAction : MotionPlayAction
{
    [JsonPropertyName("rightFrontMotionNameId_")]
    public string RightFrontMotionNameId { get; set; } = "0000";

    [JsonPropertyName("rightBackMotionNameId_")]
    public string RightBackMotionNameId { get; set; } = "0000";

    [JsonPropertyName("rightRideMotionNameId_")]
    public string RightRideMotionNameId { get; set; } = "0000";

    [JsonPropertyName("leftFrontMotionNameId_")]
    public string LeftFrontMotionNameId { get; set; } = "0000";

    [JsonPropertyName("leftBackMotionNameId_")]
    public string LeftBackMotionNameId { get; set; } = "0000";

    [JsonPropertyName("leftRideMotionNameId_")]
    public string LeftRideMotionNameId { get; set; } = "0000";

}

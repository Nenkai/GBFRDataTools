using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001MotionPlayAction : MotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001MotionPlayAction);

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

    public Em7001MotionPlayAction()
    {
        IsAnimEnd = true;
        Loop = false;
        IsStartTimeRandom = false;
        EaseOut = false;
        AnimMoveRateXZ = 1f;
        AnimMoveRateY = 1f;
        StartTime = -1f;
        InterTime = -1f;
        SpeedRate = 1f;
        MotionSlot = 0;
        MotionFlag = 0;
        FacialSeqNo = 0;
        EaseOutStartTime = -1f;
        EaseOutTime = -1f;
        MotionWeight = 1f;
        SeqNo = 0;
    }
}

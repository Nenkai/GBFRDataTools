using GBFRDataTools.FSM.Components.Actions.Motion;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300MotionPlayAction : MotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300MotionPlayAction);

    [JsonPropertyName("motionIdNamePower_")]
    public /* sys::String */ string MotionIdNamePower { get; set; } = "b000";

    public Em7300MotionPlayAction()
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

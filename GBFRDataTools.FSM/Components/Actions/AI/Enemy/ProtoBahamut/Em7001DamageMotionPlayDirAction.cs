using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001DamageMotionPlayDirAction : EmDamageMotionPlayDirAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001DamageMotionPlayDirAction);

    [JsonPropertyName("isSetPos_")]
    public bool IsSetPos { get; set; } = true;

    [JsonPropertyName("isCoolTime_")]
    public bool IsCoolTime { get; set; } = false;

    [JsonPropertyName("intervalFrame_")]
    public int IntervalFrame { get; set; } = 0;

    [JsonPropertyName("rightFrontAnimIdList_")]
    public BindingList<string> RightFrontAnimIdList { get; set; } = ["b5c0", "b5c0", "b5c1", "b5c2"];

    [JsonPropertyName("rightBackAnimIdList_")]
    public BindingList<string> RightBackAnimIdList { get; set; } = ["b5c3", "b5c3", "b5c4", "b5c5"];

    [JsonPropertyName("rightRideAnimIdList_")]
    public BindingList<string> RightRideAnimIdList { get; set; } = ["b5c6", "b5c6", "b5c7", "b5c8"];

    [JsonPropertyName("leftFrontAnimIdList_")]
    public BindingList<string> LeftFrontAnimIdList { get; set; } = ["b5d0", "b5d0", "b5d1", "b5d2"];

    [JsonPropertyName("leftBackAnimIdList_")]
    public BindingList<string> LeftBackAnimIdList { get; set; } = ["b5d3", "b5d3", "b5d4", "b5d5"];

    [JsonPropertyName("leftRideAnimIdList_")]
    public BindingList<string> LeftRideAnimIdList { get; set; } = ["b5d6", "b5d6", "b5d7", "b5d8"];
}

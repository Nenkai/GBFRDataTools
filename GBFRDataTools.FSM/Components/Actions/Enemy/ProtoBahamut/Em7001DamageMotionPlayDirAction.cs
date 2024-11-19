using System;
using System.Collections.Generic;
using System.ComponentModel;
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

public class Em7001DamageMotionPlayDirAction : EmDamageMotionPlayDirAction
{
    [JsonPropertyName("isSetPos_")]
    public bool IsSetPos { get; set; }

    [JsonPropertyName("isCoolTime_")]
    public bool IsCoolTime { get; set; }

    [JsonPropertyName("intervalFrame_")]
    public int IntervalFrame { get; set; }

    [JsonPropertyName("rightFrontAnimIdList_")]
    public BindingList<string> RightFrontAnimIdList { get; set; }

    [JsonPropertyName("rightBackAnimIdList_")]
    public BindingList<string> RightBackAnimIdList { get; set; }

    [JsonPropertyName("rightRideAnimIdList_")]
    public BindingList<string> RightRideAnimIdList { get; set; }

    [JsonPropertyName("leftFrontAnimIdList_")]
    public BindingList<string> LeftFrontAnimIdList { get; set; }

    [JsonPropertyName("leftBackAnimIdList_")]
    public BindingList<string> LeftBackAnimIdList { get; set; }

    [JsonPropertyName("leftRideAnimIdList_")]
    public BindingList<string> LeftRideAnimIdList { get; set; }
}

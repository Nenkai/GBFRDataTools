using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7000CleaveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7000CleaveAction);

    [JsonPropertyName("animationInterSec_")]
    public float AnimationInterSec { get; set; } = 1f; // Offset 0x78

    [JsonPropertyName("rightSideMotionName_")]
    public string RightSideMotionName { get; set; } // Offset 0x38

    [JsonPropertyName("leftSideMotionName_")]
    public string LeftSideMotionName { get; set; } // Offset 0x58

    [JsonPropertyName("sideIndex_")]
    public int SideIndex { get; set; } = 0; // Offset 0x80

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = -1f; // Offset 0x84

    [JsonPropertyName("lockOnListParam_")]
    public Em7000LockOnListParam LockOnListParam { get; set; } = new(); // Offset 0x88

    public Em7000CleaveAction()
    {
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200DownAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200DownAction);

    [JsonPropertyName("downTime_")]
    public float DownTime { get; set; } = 10.0f;

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } = "0610";

    [JsonPropertyName("motionIdLoop_")]
    public string MotionIdLoop { get; set; } = "0611";

    [JsonPropertyName("motionIdEnd_")]
    public string MotionIdEnd { get; set; } = "0612";
}

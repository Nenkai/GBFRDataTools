using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Furycane;

public class Em7200DownAction : ActionComponent
{
    [JsonPropertyName("downTime_")]
    public float DownTime { get; set; }

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; }

    [JsonPropertyName("motionIdLoop_")]
    public string MotionIdLoop { get; set; }

    [JsonPropertyName("motionIdEnd_")]
    public string MotionIdEnd { get; set; }
}

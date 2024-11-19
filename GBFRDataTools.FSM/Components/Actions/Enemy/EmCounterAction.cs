using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmCounterAction : EmDamageMotionPlayDirAction
{
    [JsonPropertyName("isRestart_")]
    public bool IsRestart { get; set; }
}

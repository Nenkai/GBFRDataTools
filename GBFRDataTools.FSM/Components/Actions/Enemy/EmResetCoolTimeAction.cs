using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmResetCoolTimeAction : MotionPlayAction
{
    [JsonPropertyName("valueName_")]
    public /* sys::String */ string ValueName { get; set; } = string.Empty;

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = true;
}


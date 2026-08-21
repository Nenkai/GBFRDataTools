using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2104ComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2104ComboAction);

    [JsonPropertyName("motionIdName_")]
    public string? MotionIdName { get; set; } 

    [JsonPropertyName("isAnimInter_")]
    public bool IsAnimInter { get; set; } = true; 

    [JsonPropertyName("isCallDisappearVfx_")]
    public bool IsCallDisappearVfx { get; set; } = false; 

    [JsonPropertyName("isSwitchSequenceLayer_")]
    public bool IsSwitchSequenceLayer { get; set; } = false; 
}

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Corvell;

public class Em1803JumpBreathAction : Em1800JumpBreathAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1803JumpBreathAction);

    [JsonPropertyName("firstOffsetPos_")]
    public Vector4 FirstOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("firstOffsetRotY_")]
    public float FirstOffsetRotY { get; set; } = 0f; 

    [JsonPropertyName("secondOffsetPos_")]
    public Vector4 SecondOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("secondOffsetRotY_")]
    public float SecondOffsetRotY { get; set; } = 0f; 

    [JsonPropertyName("thirdOffsetPos_")]
    public Vector4 ThirdOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("thirdOffsetRotY_")]
    public float ThirdOffsetRotY { get; set; } = 0f; 
}

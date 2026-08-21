using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600FlyFeatherShotAction : Em1600BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600FlyFeatherShotAction);

    [JsonPropertyName("bulletNum_")]
    public int BulletNum { get; set; } = 5; 

    [JsonPropertyName("loopNum_")]
    public int LoopNum { get; set; } = 1; 

    [JsonPropertyName("shiftShotOffsetRotX_")]
    public float ShiftShotOffsetRotX { get; set; } = -10f; 
}


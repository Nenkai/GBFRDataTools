using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;
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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Bird;

public class Em0300SelectAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300SelectAttackAction);

    [JsonPropertyName("selectRatio0_")]
    public int SelectRatio0 { get; set; } = 4; 

    [JsonPropertyName("selectRatio1_")]
    public int SelectRatio1 { get; set; } = 1; 

    [JsonPropertyName("selectRatio2_")]
    public int SelectRatio2 { get; set; } = 1; 
}

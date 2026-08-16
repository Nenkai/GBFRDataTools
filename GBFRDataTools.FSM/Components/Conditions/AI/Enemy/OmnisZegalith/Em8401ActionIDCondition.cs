using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401ActionIDCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401ActionIDCondition);

    [JsonPropertyName("actionID_")]
    public int ActionID { get; set; } = 0;

    [JsonPropertyName("layer_")]
    public int Layer { get; set; } = 0;
}
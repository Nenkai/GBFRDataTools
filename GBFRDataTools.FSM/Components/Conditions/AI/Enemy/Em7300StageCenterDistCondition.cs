using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7300StageCenterDistCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300StageCenterDistCondition);

    [JsonPropertyName("checkDistance_")]
    public float CheckDistance { get; set; } = 0f;
}
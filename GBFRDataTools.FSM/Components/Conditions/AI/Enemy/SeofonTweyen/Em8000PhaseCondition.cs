using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.SeofonTweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000PhaseCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000PhaseCondition);

    [Description("Blackboard key: 0x7B689D71")]
    [JsonPropertyName("phase_")]
    public int Phase { get; set; } = 0;
}
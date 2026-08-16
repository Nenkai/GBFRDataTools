using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300ShotStateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300ShotStateCondition);

    [JsonPropertyName("state_")]
    public int State { get; set; } = 0;
}
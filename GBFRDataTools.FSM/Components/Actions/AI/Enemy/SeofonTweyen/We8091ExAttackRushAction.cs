using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class We8091ExAttackRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We8091ExAttackRushAction);

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } = 0.5f;

    [JsonPropertyName("attackSignWidth_")]
    public float AttackSignWidth { get; set; } = 10f;
}
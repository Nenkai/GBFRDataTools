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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmSwordGodSpArtsFinishRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSwordGodSpArtsFinishRushAction);

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } = 0.5f;

    [JsonPropertyName("attackSignWidth_")]
    public float AttackSignWidth { get; set; } = 10f;
}
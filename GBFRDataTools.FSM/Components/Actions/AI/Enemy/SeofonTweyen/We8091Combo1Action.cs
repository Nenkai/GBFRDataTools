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
public class We8091Combo1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We8091Combo1Action);

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 0.5f;

    [JsonPropertyName("followSpeed_")]
    public float FollowSpeed { get; set; } = 7f;
}
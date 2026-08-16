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
public class Em8000InifinitoCreareAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000InifinitoCreareAction);

    [JsonPropertyName("loopSec_")]
    public float LoopSec { get; set; } = 0f;

    [JsonPropertyName("isEndMotionCancel_")]
    public bool IsEndMotionCancel { get; set; } = true;

    [JsonPropertyName("isSwordGodAttack_")]
    public bool IsSwordGodAttack { get; set; } = false;
}
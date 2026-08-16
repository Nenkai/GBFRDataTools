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
public class Em8000LowSlashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000LowSlashAction);

    [JsonPropertyName("startPhase_")]
    public int StartPhase { get; set; } = 0;

    [JsonPropertyName("isSwordGodAttack_")]
    public bool IsSwordGodAttack { get; set; } = false;

    [JsonPropertyName("isSwordShotAttack_")]
    public bool IsSwordShotAttack { get; set; } = false;

    [JsonPropertyName("isEnableFinishCancelFlag_")]
    public bool IsEnableFinishCancelFlag { get; set; } = true;

    [JsonPropertyName("isHL_")]
    public bool IsHL { get; set; } = false;
}
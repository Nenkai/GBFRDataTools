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
[Obsolete("Not exposed by the executable.")]
[Description("Added in Endless Ragnarok. Not exposed by the executable.")]
public class Em8000SlashComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000ComboCAction);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("startPhase_")]
    public int StartPhase { get; set; } = 0;

    [JsonPropertyName("isSwordGodAttack_")]
    public bool IsSwordGodAttack { get; set; } = false;

    [JsonPropertyName("isSwordShotAttack_")]
    public bool IsSwordShotAttack { get; set; } = false;

    [JsonPropertyName("isEnableFinishCancelFlag_")]
    public bool IsEnableFinishCancelFlag { get; set; } = true;

    [JsonPropertyName("comboFinishCancelFrame_")]
    public int ComboFinishCancelFrame { get; set; } = -1;

    [JsonPropertyName("isHL_")]
    public bool IsHL { get; set; } = false;
}


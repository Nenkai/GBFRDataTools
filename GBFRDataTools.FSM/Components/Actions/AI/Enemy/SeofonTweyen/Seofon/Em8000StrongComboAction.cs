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
public class Em8000StrongComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000StrongComboAction);

    [JsonPropertyName("startComboPhase_")]
    public int StartComboPhase { get; set; } = 0;

    [JsonPropertyName("isSwordShotAttack_")]
    public bool IsSwordShotAttack { get; set; } = false;

    [JsonPropertyName("isEnableFinishCancelFlag_")]
    public bool IsEnableFinishCancelFlag { get; set; } = true;

    [JsonPropertyName("comboFinishCancelFrame_")]
    public int ComboFinishCancelFrame { get; set; } = -1;

    [JsonPropertyName("isHL_")]
    public bool IsHL { get; set; } = false;
}

using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable.")]
public class Em0006ShieldTackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0006ShieldTackleAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; }

    [JsonPropertyName("comboSlashDist_")]
    public float ComboSlashDist { get; set; }

    [JsonPropertyName("isCancelAction_")]
    public bool IsCancelAction { get; set; }

    [JsonPropertyName("isCancelActionEnd_")]
    public bool IsCancelActionEnd { get; set; }

    [JsonPropertyName("isComboAction_")]
    public bool IsComboAction { get; set; }
}
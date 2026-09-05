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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkTheEndAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkTheEndAction);

    [JsonPropertyName("isCheckLinkOrSpAttack_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsCheckLinkOrSpAttack { get; set; } = false;

    [JsonPropertyName("isChangeEnemyTypeChargeMax_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsChangeEnemyTypeChargeMax { get; set; } = false;
}
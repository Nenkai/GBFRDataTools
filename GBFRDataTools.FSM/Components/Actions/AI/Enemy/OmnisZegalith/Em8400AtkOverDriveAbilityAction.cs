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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkOverDriveAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkOverDriveAbilityAction);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("isUseEndMotion_")]
    public bool IsUseEndMotion { get; set; } = true;
}

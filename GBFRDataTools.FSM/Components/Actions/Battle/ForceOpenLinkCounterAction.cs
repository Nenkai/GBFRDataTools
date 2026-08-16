using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ForceOpenLinkCounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ForceOpenLinkCounterAction);

    [JsonPropertyName("forceOpen_")]
    public bool ForceOpen { get; set; } = false;
}
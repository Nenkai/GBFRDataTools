using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200LangelaanFieldRequestStartAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200LangelaanFieldRequestStartAction);

    [JsonPropertyName("onEnd_")]
    public bool OnEnd { get; set; } = false;
}
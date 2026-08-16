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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100ShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100ShotAction);

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "-";

    [JsonPropertyName("isShotTriggerSequenceFlag_")]
    public bool IsShotTriggerSequenceFlag { get; set; } = false;
}
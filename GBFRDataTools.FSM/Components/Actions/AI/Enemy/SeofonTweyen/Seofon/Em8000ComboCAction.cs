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
public class Em8000ComboCAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000ComboCAction);

    [JsonPropertyName("isSwordShotAttack_")]
    public bool IsSwordShotAttack { get; set; } = false;

    [JsonPropertyName("isEnableCancelFlag_")]
    public bool IsEnableCancelFlag { get; set; } = true;
}


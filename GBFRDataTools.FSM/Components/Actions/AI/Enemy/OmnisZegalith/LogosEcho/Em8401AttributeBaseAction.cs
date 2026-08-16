using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401AttributeBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401AttributeBaseAction);

    [JsonPropertyName("parentActionType_")]
    public int ParentActionType { get; set; } = 0;

    [JsonPropertyName("attributePhase_")]
    public int AttributePhase { get; set; } = 0;

    [JsonPropertyName("isUseInfinityAttack_")]
    public bool IsUseInfinityAttack { get; set; } = false;
}

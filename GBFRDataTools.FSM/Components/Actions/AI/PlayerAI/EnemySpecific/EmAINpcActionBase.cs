using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmAINpcActionBase : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiEm7700SpArts);

    [JsonPropertyName("isUseNavMesh_")]
    public bool IsUseNavMesh { get; set; } = false;

    [JsonPropertyName("isMyUpdateFreeFall_")]
    public bool IsMyUpdateFreeFall { get; set; } = false;
}

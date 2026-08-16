using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AiEm8000CarroMagnifico : EmAINpcActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiEm8000CarroMagnifico);

    [JsonPropertyName("targetOffsetPos_")]
    public BindingList<Vector4> TargetOffsetPos { get; set; } = [.. Enumerable.Repeat(new Vector4(), 3).ToList()]; // std::array<Hw::cVec4,3>
}

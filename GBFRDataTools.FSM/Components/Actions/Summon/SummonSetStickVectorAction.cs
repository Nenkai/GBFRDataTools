using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonSetStickVectorAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetStickVectorAction);

    [JsonPropertyName("blackBoardValueName_")]
    public string BlackBoardValueName { get; set; }

    [JsonPropertyName("isStickYOnly_")]
    public bool IsStickYOnly { get; set; } = false;
}

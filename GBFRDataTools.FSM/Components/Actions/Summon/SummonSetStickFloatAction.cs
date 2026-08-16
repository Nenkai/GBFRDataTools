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
public class SummonSetStickFloatAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetStickFloatAction);

    [JsonPropertyName("stickInputType_")]
    public int StickInputType { get; set; } = 0;

    [JsonPropertyName("blackBoardValueName_")]
    public string BlackBoardValueName { get; set; }
}

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
public class SummonGravitySetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonGravitySetAction);

    [JsonPropertyName("optionIdx_")]
    public int OptionIdx { get; set; } = 0;

    [JsonPropertyName("isUndoEnd_")]
    public bool IsUndoEnd { get; set; } = false;
}

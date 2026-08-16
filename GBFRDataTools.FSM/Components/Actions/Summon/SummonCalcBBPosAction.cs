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
public class SummonCalcBBPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCalcBBPosAction);

    [JsonPropertyName("posBBName_")]
    public string PosBBName { get; set; }

    [JsonPropertyName("forwardBBName_")]
    public string ForwardBBName { get; set; }

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUseForward_")]
    public bool IsUseForward { get; set; } = true;

    [JsonPropertyName("isUpdateCalc_")]
    public bool IsUpdateCalc { get; set; } = false;
}

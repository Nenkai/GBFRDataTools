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
public class SummonTargetShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonTargetShotAction);

    [JsonPropertyName("fsmClassName_")]
    public string FsmClassName { get; set; }

    [JsonPropertyName("fsmInfixName_")]
    public string FsmInfixName { get; set; }

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUseParts_")]
    public bool IsUseParts { get; set; } = false;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = 0;

    [JsonPropertyName("blackBoardValueName_")]
    public string BlackBoardValueName { get; set; }
}

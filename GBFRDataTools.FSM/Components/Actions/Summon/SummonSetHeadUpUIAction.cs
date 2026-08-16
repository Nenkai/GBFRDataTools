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
public class SummonSetHeadUpUIAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetHeadUpUIAction);

    [JsonPropertyName("isUseOverrideParams_")]
    public bool IsUseOverrideParams { get; set; } = true;

    [JsonPropertyName("headUpUIUnitIndex_")]
    public int HeadUpUIUnitIndex { get; set; } = -1;

    [JsonPropertyName("headUpUIJointIndex_")]
    public int HeadUpUIJointIndex { get; set; } = 5;

    [JsonPropertyName("headUpUIPosOffset_")]
    public Vector4 HeadUpUIPosOffset { get; set; } = new Vector4(0f, 0.4f, 0f, 0f);
}

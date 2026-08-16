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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Lilith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4502InitialSetupAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4502InitialSetupAction);

    [JsonPropertyName("posOffset_")]
    public Vector4 PosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("rotOffset_")]
    public Vector4 RotOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("addGageAmount_")]
    public float AddGageAmount { get; set; } = 30f;
}

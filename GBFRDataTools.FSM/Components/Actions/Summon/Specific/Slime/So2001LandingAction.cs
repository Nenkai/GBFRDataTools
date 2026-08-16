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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Slime;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So2001LandingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So2001LandingAction);

    [JsonPropertyName("lineNum_")]
    public int LineNum { get; set; } = 4;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 1f;

    [JsonPropertyName("disableAttributeCheck_")]
    public bool DisableAttributeCheck { get; set; } = false;

    [JsonPropertyName("disablePosAdjust_")]
    public bool DisablePosAdjust { get; set; } = false;

    [JsonPropertyName("disableSetFreeFallStop_")]
    public bool DisableSetFreeFallStop { get; set; } = false;
}

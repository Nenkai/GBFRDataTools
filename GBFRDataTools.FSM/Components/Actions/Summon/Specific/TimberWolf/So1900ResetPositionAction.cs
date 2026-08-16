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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.TimberWolf;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So1900ResetPositionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So1900ResetPositionAction);

    [JsonPropertyName("scalar_")]
    public float Scalar { get; set; } = 0f;
}

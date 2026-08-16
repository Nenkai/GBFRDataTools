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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.WheelOfFate;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So6400StopRotateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So6400StopRotateAction);

    [JsonPropertyName("afterMinRotate_")]
    public float AfterMinRotate { get; set; } = 1f;

    [JsonPropertyName("afterMaxSpeedRate_")]
    public float AfterMaxSpeedRate { get; set; } = 1f;
}

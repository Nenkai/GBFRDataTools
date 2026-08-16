using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Lucilius;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So0000SwordSlashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So0000SwordSlashAction);

    [JsonPropertyName("isUseShot_")]
    public bool IsUseShot { get; set; } = false;

    [JsonPropertyName("isUseThreeWayShot_")]
    public bool IsUseThreeWayShot { get; set; } = false;

    [JsonPropertyName("threeWayRotY_")]
    public float ThreeWayRotY { get; set; } = 90f;

    [JsonPropertyName("startFrame_")]
    public int StartFrame { get; set; } = 40;
}
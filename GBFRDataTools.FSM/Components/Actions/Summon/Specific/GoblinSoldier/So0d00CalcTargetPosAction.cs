using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.GoblinSoldier;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So0d00CalcTargetPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So0d00CalcTargetPosAction);

    [JsonPropertyName("targetDist_")]
    public float TargetDist { get; set; } = 1f;

    [JsonPropertyName("targetPosBBName_")]
    public string TargetPosBBName { get; set; }
}
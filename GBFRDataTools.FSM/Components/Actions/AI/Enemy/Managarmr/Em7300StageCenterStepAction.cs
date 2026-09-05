using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7300StageCenterStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300StageCenterStepAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0f;

    [JsonPropertyName("homingRadianMax_")]
    public float HomingRadianMax { get; set; } = 0f;
}
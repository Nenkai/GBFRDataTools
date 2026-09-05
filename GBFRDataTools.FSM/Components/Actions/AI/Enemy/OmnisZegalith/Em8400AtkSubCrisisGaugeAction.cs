using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkSubCrisisGaugeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkSubCrisisGaugeAction);

    [JsonPropertyName("subCrisisGaugePercent_")]
    public float SubCrisisGaugePercent { get; set; } = 80.0f;
}
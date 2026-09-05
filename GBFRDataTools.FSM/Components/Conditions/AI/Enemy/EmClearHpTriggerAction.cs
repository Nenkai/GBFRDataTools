using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmClearHpTriggerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmClearHpTriggerAction);

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; } = true;
}
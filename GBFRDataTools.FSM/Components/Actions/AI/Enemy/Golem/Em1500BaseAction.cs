using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500BaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500BaseAction);

    [JsonPropertyName("isComboBefore_")]
    public bool IsComboBefore { get; set; } = false; 

    [JsonPropertyName("isComboAfter_")]
    public bool IsComboAfter { get; set; } = false;

    [JsonPropertyName("startSec_")]
    public float StartSec { get; set; } = -1f;

    [JsonPropertyName("interpSec_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float InterpSec { get; set; } = -1f;

    [JsonPropertyName("endSec_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float EndSec { get; set; } = -1f;
}

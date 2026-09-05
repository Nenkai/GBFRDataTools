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
public class EmSetCoolTimeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSetCoolTimeAction);

    [JsonPropertyName("valueName_")]
    public string? ValueName { get; set; }

    [JsonPropertyName("coolTimeSetType_")]
    public CoolTimeSetType CoolTimeSetType { get; set; } = CoolTimeSetType.Type0;

    [JsonPropertyName("setTimeSec_")]
    public float SetTimeSec { get; set; } = 0f;

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = true;
}

public enum CoolTimeSetType
{
    Type0 = 0,
    Type1 = 1
}
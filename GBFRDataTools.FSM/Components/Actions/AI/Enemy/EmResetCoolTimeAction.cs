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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmResetCoolTimeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmResetCoolTimeAction);

    [JsonPropertyName("valueName_")]
    public /* sys::String */ string ValueName { get; set; } = string.Empty;

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = true;

    [JsonPropertyName("isNoResult_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsNoResult { get; set; } = false;

    [JsonPropertyName("commitIsEnable_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool CommitIsEnable { get; set; } = true;

    public override string GetCaption()
    {
        return $"{ValueName} (Enable: {IsEnable})";
    }
}


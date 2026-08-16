using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShuffleGameMemberMotion : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShuffleGameMemberMotion);

    [JsonPropertyName("index_")]
    public int Index { get; set; } = 0;

    [JsonPropertyName("animationName_")]
    public string AnimationName { get; set; }

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; } = false;

    [JsonPropertyName("isAutoVaried_")]
    public bool IsAutoVaried { get; set; } = false;
}
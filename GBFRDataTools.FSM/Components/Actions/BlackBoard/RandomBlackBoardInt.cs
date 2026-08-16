using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[GameSupport(GameVersion.EndlessRagnarok)]
public class RandomBlackBoardInt : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(RandomBlackBoardInt);

    [JsonPropertyName("intName_")]
    public string IntName { get; set; }

    [JsonPropertyName("min_")]
    public int Min { get; set; } = 0;

    [JsonPropertyName("max_")]
    public int Max { get; set; } = 0;

    [JsonPropertyName("isEndlessMode_")]
    public bool IsEndlessMode { get; set; } = false;
}

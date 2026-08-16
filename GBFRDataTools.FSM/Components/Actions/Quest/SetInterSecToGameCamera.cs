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

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetInterSecToGameCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetInterSecToGameCamera);

    [JsonPropertyName("complementTime_")]
    public float ComplementTime { get; set; } = 0.5f;
}

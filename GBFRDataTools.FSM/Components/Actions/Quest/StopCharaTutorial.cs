using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class StopCharaTutorial : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StopCharaTutorial);

    [JsonPropertyName("stopCharaTutorial_")]
    public bool StopCharaTutorial_ { get; set; } = false;
}

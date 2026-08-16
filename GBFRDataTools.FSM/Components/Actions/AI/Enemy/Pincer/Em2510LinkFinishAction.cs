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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Pincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2510LinkFinishAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510LinkFinishAction);

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1.0f;
}

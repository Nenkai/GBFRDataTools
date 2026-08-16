using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000CombinationSpArtsCuntinAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000CombinationSpArtsCuntinAction);

    [JsonPropertyName("posParam_")]
    public EmPositionParam PosParam { get; set; } = new();
}


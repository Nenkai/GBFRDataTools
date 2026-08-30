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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001CatastropheAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001CatastropheAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0;

    [JsonPropertyName("frontType_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int FrontType { get; set; } = 0;

    [JsonPropertyName("slideLength_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float SlideLength { get; set; } = 0f;

}

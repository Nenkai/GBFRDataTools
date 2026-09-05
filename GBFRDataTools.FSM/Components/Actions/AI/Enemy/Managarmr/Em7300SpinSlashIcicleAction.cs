using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7300SpinSlashIcicleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300SpinSlashIcicleAction);

    [JsonPropertyName("animStartFrame_")]
    public int AnimStartFrame { get; set; } = 24;
}
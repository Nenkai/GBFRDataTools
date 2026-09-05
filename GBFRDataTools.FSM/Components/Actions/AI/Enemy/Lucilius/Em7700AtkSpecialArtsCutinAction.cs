using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkSpecialArtsCutinAction : Em7700CutinBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkSpecialArtsCutinAction);

    [JsonPropertyName("isShort_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsShort { get; set; } = false;

    public Em7700AtkSpecialArtsCutinAction()
    {
        IsResetCamera = true;
        CanSkipCutin = false;
        UseCutMax = 1;
        IsUseDarkVfx = true;
    }
}
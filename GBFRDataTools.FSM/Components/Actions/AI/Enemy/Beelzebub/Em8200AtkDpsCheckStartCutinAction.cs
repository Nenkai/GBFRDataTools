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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200AtkDpsCheckStartCutinAction : Em8200CutinBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkDpsCheckStartCutinAction);

    [JsonPropertyName("is2ndDPS_")]
    public bool Is2ndDPS { get; set; } = false;

    public Em8200AtkDpsCheckStartCutinAction()
    {
        IsResetCamera = true;
        CanSkipCutin = false;
        UseCutMax = 1;
        IsUseDarkVfx = true;
    }
}
using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7700AtkOneShotTrialAction : Em7700CutinBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkOneShotTrialAction);

    public Em7700AtkOneShotTrialAction()
    {
        IsResetCamera = true;
        CanSkipCutin = false;
        UseCutMax = 1;
        IsUseDarkVfx = true;
    }
}
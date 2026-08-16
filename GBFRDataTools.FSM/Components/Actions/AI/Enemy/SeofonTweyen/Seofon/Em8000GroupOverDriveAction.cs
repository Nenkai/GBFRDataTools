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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000GroupOverDriveAction : EmGroupOverDriveAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000GroupOverDriveAction);

    public Em8000GroupOverDriveAction()
    {
        InterSec = 0.2f;
        IsBeginOneOnOneMode = false;
        CutinOffsetRotY = 0f;
        CutinOffsetRotYByHL = 0f;
    }
}

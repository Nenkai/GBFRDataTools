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
public class Em8000GroupEscapeAction : EmGroupEscapeAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000GroupEscapeAction);

    public Em8000GroupEscapeAction()
    {
        IsBackJump = false;
        IsSuspendByActionEnd = false;
        MaxJumpHeight = 10f;
        IsLandingEndTimeSet = false;
        LandingEndTimeSec = 1f;
        TurnTargetPos = new Vector4(-270.98f, 88.41f, -51.95f, 1f);
    }
}

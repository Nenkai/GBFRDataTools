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
public class Em8000ComebackAction : EmGroupComebackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000ComebackAction);

    public Em8000ComebackAction()
    {
        IsComebackActor = false;
        IsUseFade = false;
        IsUseGravity = true;
        PlayerOffsetDist = 15.0f;
        ComebackOffsetPos = new Vector4(0f, 0f, 0f, 1f);
    }
}
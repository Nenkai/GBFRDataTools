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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100ComebackAction : EmGroupComebackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100ComebackAction);

    [JsonPropertyName("arrowMotList_")]
    public BindingList<string> ArrowMotList { get; set; } = [];

    public Em8100ComebackAction()
    {
        IsComebackActor = false;
        IsUseFade = false;
        IsUseGravity = true;
        PlayerOffsetDist = 15f;
        ComebackOffsetPos = new Vector4(0f, 0f, 0f, 1f);
    }
}
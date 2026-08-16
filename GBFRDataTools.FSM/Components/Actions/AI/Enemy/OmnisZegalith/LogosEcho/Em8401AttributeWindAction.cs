using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401AttributeWindAction : Em8401AttributeBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401AttributeWindAction);

    [JsonPropertyName("isFirstMotionInter_")]
    public bool IsFirstMotionInter { get; set; } = true;

    public Em8401AttributeWindAction()
    {
        ParentActionType = 0;
        AttributePhase = 0;
        IsUseInfinityAttack = false;
    }
}

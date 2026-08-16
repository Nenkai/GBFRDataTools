using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[GameSupport(GameVersion.EndlessRagnarok)]
public class BehaviorSetRotFromBlackBoardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorSetRotFromBlackBoardAction);

    [JsonPropertyName("rotBlackBoardKey_")]
    public string RotBlackBoardKey { get; set; }

    [JsonPropertyName("rotPosBlackBoardKey_")]
    public string RotPosBlackBoardKey { get; set; }
}
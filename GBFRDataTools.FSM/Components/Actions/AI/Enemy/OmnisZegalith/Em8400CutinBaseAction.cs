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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400CutinBaseAction : EmBossCutinBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400CutinBaseAction);

    [JsonPropertyName("cutinPlayPosList_")]
    public BindingList<Vector4> CutinPlayPosList { get; set; } = []; // std::vector<Hw::cVec4>
}

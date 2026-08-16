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
public class Em8400AtkStraightPlasmaShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkStraightPlasmaShotAction);

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 90;

    [JsonPropertyName("attackSignFrame_")]
    public int AttackSignFrame { get; set; } = 30;

    [JsonPropertyName("homingFrame_")]
    public int HomingFrame { get; set; } = 30;

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "shot_straight";

    [JsonPropertyName("shotStartPosOffset_")]
    public Vector4 ShotStartPosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shotParameterList_")]
    public BindingList<ShotParameter> ShotParameterList { get; set; } = []; // std::vector<BT::Em8400AtkStraightPlasmaShotAction::ShotParameter>

    [JsonPropertyName("attackSignAddDelayFrame_")]
    public int AttackSignAddDelayFrame { get; set; } = 2;

    public class ShotParameter /* Em8400AtkStraightPlasmaShotAction::ShotParameter */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    }
}

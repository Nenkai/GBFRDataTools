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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkMovePlasmaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkMovePlasmaAction);

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 90;

    [JsonPropertyName("shotPosParameterList_")]
    public BindingList<ShotParameter> ShotPosParameterList { get; set; } = []; // std::vector<BT::Em8400AtkMovePlasmaAction::ShotParameter>

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "shot_melee_bomb";

    [JsonPropertyName("baseOffsetPos_")]
    public Vector4 BaseOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shotDuplicateNum_")]
    public int ShotDuplicateNum { get; set; } = -1;

    public class ShotParameter /* Em8400AtkMovePlasmaAction::ShotParameter */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    
        [JsonPropertyName("delayTimeSec_")]
        public float DelayTimeSec { get; set; }
    
        [JsonPropertyName("singleShot_")]
        public bool SingleShot { get; set; }
    }
}
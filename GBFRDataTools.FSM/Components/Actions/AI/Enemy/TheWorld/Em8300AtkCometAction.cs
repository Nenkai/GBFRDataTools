using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkCometAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkCometAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.4f;

    [JsonPropertyName("cometTime_")]
    public float CometTime { get; set; } = 2.5f;

    [JsonPropertyName("wingCometTime_")]
    public float WingCometTime { get; set; } = 2.5f;

    [JsonPropertyName("cometSignTime_")]
    public float CometSignTime { get; set; } = 1.5f;

    [JsonPropertyName("wingCometSignTime_")]
    public float WingCometSignTime { get; set; } = 1.5f;

    [JsonPropertyName("finishSignTime_")]
    public float FinishSignTime { get; set; } = 2.5f;

    [JsonPropertyName("cometInterval_")]
    public float CometInterval { get; set; } = 0.15f;

    [JsonPropertyName("wingCometInterval_")]
    public float WingCometInterval { get; set; } = 0.15f;

    [JsonPropertyName("cometSignInterval_")]
    public float CometSignInterval { get; set; } = 0.05f;

    [JsonPropertyName("wingCometSignInterval_")]
    public float WingCometSignInterval { get; set; } = 0.05f;

    [JsonPropertyName("bigCometInterval_")]
    public float BigCometInterval { get; set; } = 0.5f;

    [JsonPropertyName("cometTable_")]
    public BindingList<CometTable_> CometTable { get; set; } = []; // std::vector<BT::Em8300AtkCometAction::CometTable>

    [JsonPropertyName("wingCometTable_")]
    public BindingList<CometTable_> WingCometTable { get; set; } = []; // std::vector<BT::Em8300AtkCometAction::CometTable>

    public class CometTable_ /* Em8300AtkCometAction::CometTable */
    {
        [JsonPropertyName("posInfo_")]
        public BindingList<CometPos> PosInfo { get; set; } = []; // std::vector<BT::Em8300AtkCometAction::CometPos>
    }

    public class CometPos /* Em8300AtkCometAction::CometPos */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("interval_")]
        public float Interval { get; set; }
    
        [JsonPropertyName("sizeRate_")]
        public float SizeRate { get; set; }
    
        [JsonPropertyName("isBig_")]
        public bool IsBig { get; set; }
    }
}

